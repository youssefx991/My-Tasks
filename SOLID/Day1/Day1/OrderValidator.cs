using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class OrderValidator
    {
        public bool IsValid(Order order)
        {
            if (order.Items.Count == 0) return false;
            if (string.IsNullOrWhiteSpace(order.CustomerEmail)) return false;
            // Add more validation rules as needed
            return true;
        }
    }
}
