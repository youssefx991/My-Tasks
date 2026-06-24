using ITI46.Ecommerce.Core.Models;
using ITI46.Ecommerce.Core.Ordering.Models;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IOrderService
    {
        Task<CreationResult> PlaceOrder(Order order);
    }
}
