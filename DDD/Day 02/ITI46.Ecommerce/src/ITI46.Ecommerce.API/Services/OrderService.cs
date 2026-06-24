using ITI46.Ecommerce.Core.Interfaces;
using ITI46.Ecommerce.Core.Models;
using ITI46.Ecommerce.Core.Ordering.Entities.CustomerAggregate;
using ITI46.Ecommerce.Core.Ordering.Entities.OrderAggregate;
using ITI46.Ecommerce.Core.Ordering.Events;
using ITI46.Ecommerce.Core.Ordering.Interfaces;
using ITI46.Ecommerce.Infrastructure;

namespace ITI46.Ecommerce.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext dbContext;
        private readonly IRepository<Order, int> orderRepository;
        private readonly IThiredPartyInventoryConnector inventoryConnector;
        private readonly IEventDispatcher<OrderCreatedEvent> eventDispatcher;
        private readonly IDeliveryFeesCalculator deliveryFeesCalculator;

        public OrderService(IRepository<Order, int> orderRepository, IThiredPartyInventoryConnector inventoryConnector, IEventDispatcher<OrderCreatedEvent> eventDispatcher, IDeliveryFeesCalculator deliveryFeesCalculator)
        {
            this.orderRepository = orderRepository;
            this.inventoryConnector = inventoryConnector;
            this.eventDispatcher = eventDispatcher;
            this.deliveryFeesCalculator = deliveryFeesCalculator;
        }

        public async Task<CreationResult> PlaceOrder(Order order)
        {
            if (order is null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            var inventory = await inventoryConnector.CheckQuantity(order.GetProductQuantities());

            // Check Quantity

            // Replace with retrieving the customer from the database using order.CustomerId
            Customer customer = null;

            var deliveryFees = deliveryFeesCalculator.Calculate(order, customer);
            order.CalculateTotalPrice(deliveryFees);

            await orderRepository.Insert(order);

            var orderCreatedEvent = new OrderCreatedEvent(order.Id, order.CustomerId, order.TotalPrice);
            await eventDispatcher.Dispatch(orderCreatedEvent);

            //await notificationManager.Notify(new Message
            //{
            //    RecipientId = order.CustomerId,
            //    Subject = "Order Placed!",
            //    Body = $"Congrats! Your order #{order.Id} has been placed successfully."
            //});

            return new CreationResult
            {
                Success = true,
                OrderId = order.Id,
            };
        }
    }
}
