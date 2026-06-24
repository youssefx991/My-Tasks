using ITI46.Ecommerce.Core.Ordering.Models;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IDeliveryFeesCalculator
    {
        decimal Calculate(Order order, Customer customer);
    }
}
