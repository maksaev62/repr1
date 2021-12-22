using System;
using System;
using repr1.Domain;
using repr1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace repr1.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public Car Read(int carId)
        {
            return Storage.CarStorage.Read(carId);
        }

        [HttpPost]
        public Car Update(int carId, Car newCar)
        {
            return Storage.CarStorage.Update(carId, newCar);
        }

        [HttpDelete]
        public bool Delete(int carId)
        {
            return Storage.CarStorage.Delete(cartId); ;
        }
    }
}

