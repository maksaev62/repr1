using System;

namespace repr1.Domain
{

    public class Request
    {

        public int OrderId { get; set; }

        public string Model { get; set; }

        public string Mark { get; set; }

        public string BodyType { get; set; }

        public DateTime Year { get; set; }

        public int Sum { get; set; }

        public int AutopickerId { get; set; }

        public int ClientId { get; set; }
    }
}