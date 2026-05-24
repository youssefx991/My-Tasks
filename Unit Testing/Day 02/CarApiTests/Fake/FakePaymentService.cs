using CarAPI.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarApiTests.Fake
{
    internal class FakePaymentService : IPaymentService
    {
        public string Pay(double amount)
        {
            return "Success";
        }
    }
}
