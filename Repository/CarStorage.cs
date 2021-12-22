using System;
using repr1.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace repr1.Repository
{
    public class Car
    {
        private Dictionary<int, Car> Cars { get; } = new Dictionary<int, Car>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CarStorage() => Connection.Open();

        public void Create(Cart car)
        {
            Cars.Add(car.CarId, car);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Car Read(int carId)
        {
            return Cars[carId];
        }

        public Car Update(int carId, Car newCar)
        {
            Cars[carId] = newCar;
            return Cars[carId];
        }

        public bool Delete(int carId)
        {
            return Cars.Remove(carId);
        }
    }
}
