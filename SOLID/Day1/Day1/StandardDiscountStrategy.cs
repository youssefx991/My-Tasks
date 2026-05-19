using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class StandardDiscountStrategy : IDiscountStrategy
    {
        public decimal GetDiscount(Order order)
        {
            return 0.00m; // No discount for standard orders
        }
    }
}
