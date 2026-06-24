namespace ITI46.Ecommerce.Core.Ordering.Models
{
    public class OrderItem
    {
        public int Id { get; private set; }

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
