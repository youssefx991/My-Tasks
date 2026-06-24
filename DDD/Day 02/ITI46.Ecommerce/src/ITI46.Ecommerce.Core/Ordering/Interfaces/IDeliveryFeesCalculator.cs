using ITI46.Ecommerce.Core.Ordering.Entities.CustomerAggregate;
using ITI46.Ecommerce.Core.Ordering.Entities.OrderAggregate;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IDeliveryFeesCalculator
    {
        decimal Calculate(Order order, Customer customer);
    }
}
