using System;
using repr1.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace repr1.Repository
{
    public class RequestStorage
    {
        private Dictionary<int, Request> Requests { get; } = new Dictionary<int, Request>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public RequestStorage() => Connection.Open();

        public void Create(Request request)
        {
            Requests.Add(request.RequestId, request);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Request Read(int requestId)
        {
            return Requests[requestId];
        }

        public Request Update(int requestId, Request newRequest)
        {
            Requests[requestId] = newRequest;
            return Requests[requestId];
        }

        public bool Delete(int requestId)
        {
            return Requests.Remove(requestId);
        }
    }
}
}
