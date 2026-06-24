using ITI46.Ecommerce.Core.Base;

namespace ITI46.Ecommerce.Core.Ordering.Entities.OrderAggregate
{
    public class OrderItem : Entity<int>
    {
        public int ProductId { get; private set; }

        public decimal ProductPrice { get; private set; }

        public int Quantity { get; private set; }

        public decimal TotalPrice => ProductPrice * Quantity;

        public OrderItem(int id, int productId, decimal productPrice, int quantity)
        {
            Id = id;
            ProductId = productId;
            ProductPrice = productPrice;
            Quantity = quantity;
        }

        
    }
}
