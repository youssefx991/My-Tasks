using ITI46.Ecommerce.Core.Ordering.Entities.InventoryAggregate;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IThiredPartyInventoryConnector
    {
        Task<Inventory> CheckQuantity(IEnumerable<(int productId, int quantity)> products);
    }
}
