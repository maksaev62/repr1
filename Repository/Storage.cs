using System;

namespace repr1.Repository
{
    public static class Storage
    {
        public static readonly ClientStorage clientStorage = new();
        public static readonly CarStorage CarStorage = new();
        public static readonly RequestStorage RequestStorage = new();
        public static readonly PaymentStorage PaymentStorage = new();
        public static readonly AutopickerStorage AutopickerStorage = new();
    }
}
