using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class PremiumDiscountStrategy : IDiscountStrategy
    {
        public decimal GetDiscount(Order order)
        {
            return 0.10m; // 10% discount for premium orders
        }
    }
}
