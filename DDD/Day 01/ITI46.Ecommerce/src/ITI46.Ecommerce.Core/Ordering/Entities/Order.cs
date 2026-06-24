using ITI46.Ecommerce.Core.Base;
using ITI46.Ecommerce.Core.Ordering.ValueObjects;
using System.Text.Json.Serialization;

namespace ITI46.Ecommerce.Core.Ordering.Models
{
    public class Order : Entity<int>
    {
        public DateTime Created { get; private set; }

        public int CustomerId { get; private set; }

        public int DeliveryId { get; private set; }

        public decimal DeliveryFee { get; private set; }
        
        public Address Address { get; }

        [JsonIgnore]
        public decimal TotalPrice { get; private set; }

        public IEnumerable<OrderItem> OrderItems { get; private set; }

        public Customer Customer { get; private set; }

        // EF only
        private Order() { }

        public Order(int id, DateTime created, int customerId, int deliveryId, decimal deliveryFee, Address address, IEnumerable<OrderItem> orderItems)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(customerId);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(deliveryId);


            if (OrderItems?.Any() != true)
            {
                throw new ArgumentException("At least one item required!");
            }

            Id = id;
            Created = created;
            CustomerId = customerId;
            DeliveryId = deliveryId;
            DeliveryFee = deliveryFee;
            Address = address;
            OrderItems = orderItems;
        }

        public void CalculateTotalPrice(decimal deliveryFee)
        {
            TotalPrice = OrderItems.Sum(i => i.TotalPrice) + deliveryFee;
        }
    }
}
