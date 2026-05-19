using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class BulkDiscountStrategy : IDiscountStrategy
    {
        public decimal GetDiscount(Order order)
        {
            return 0.20m; // 20% discount for bulk orders
        }
    }
}
