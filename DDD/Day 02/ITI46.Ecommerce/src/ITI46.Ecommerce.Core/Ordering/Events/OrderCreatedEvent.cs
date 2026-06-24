using ITI46.Ecommerce.Core.Ordering.Interfaces;

namespace ITI46.Ecommerce.Core.Ordering.Events
{
    public class OrderCreatedEvent : IEvent
    {
        public string EventName => "OrderCreared";

        public DateTime CreateOn => DateTime.UtcNow;

        public int Id { get; private set; }

        public int CustomerId { get; private set; }

        public decimal OrderAmount { get; private set; }

        public OrderCreatedEvent(int id, int customerId, decimal orderAmount)
        {
            Id = id;
            CustomerId = customerId;
            OrderAmount = orderAmount;
        }
    }
}
