using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class OrderDiscount : IOrderDiscount
    {
        private readonly IDiscountStrategy _discountStrategy;

        public OrderDiscount(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateFinalAmount(Order order)
        {
            var discount = CalculateDiscount(order);
            var finalAmount = order.TotalAmount - (order.TotalAmount * discount);
            return finalAmount;
        }

        // [VIOLATION 4: OCP] Every new order type = edit this method
        private decimal CalculateDiscount(Order order)
        {
            return _discountStrategy.GetDiscount(order);
        }
    }
}
