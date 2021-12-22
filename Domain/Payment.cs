using System;

namespace repr1.Domain
{

    public class Payment
    {

        public string Payment { get; set; }

        public int OrderId { get; set; }

        public int OrderPrice { get; set; }

        public int Prepayment { get; set; }

    }
}
