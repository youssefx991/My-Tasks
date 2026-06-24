using ITI46.Ecommerce.Core.Ordering.Enums;
using ITI46.Ecommerce.Core.Ordering.Interfaces;
using ITI46.Ecommerce.Core.Ordering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI46.Ecommerce.Core.Ordering.Services
{
    public class DeliveryFeesCalculator : IDeliveryFeesCalculator
    {
        public decimal Calculate(Order order, Customer customer)
        {

            if (customer.Type == CustomerType.Premium)
            {
                return 1;
            }

            return order.DeliveryFee;
        }
    }
}
