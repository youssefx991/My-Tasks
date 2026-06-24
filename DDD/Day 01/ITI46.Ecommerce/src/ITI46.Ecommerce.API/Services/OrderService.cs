using ITI46.Ecommerce.Core.Interfaces;
using ITI46.Ecommerce.Core.Models;
using ITI46.Ecommerce.Core.Ordering.Interfaces;
using ITI46.Ecommerce.Core.Ordering.Models;
using ITI46.Ecommerce.Infrastructure;

namespace ITI46.Ecommerce.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext dbContext;
        private readonly INotificationManager notificationManager;
        private readonly IDeliveryFeesCalculator deliveryFeesCalculator;

        public OrderService(AppDbContext dbContext, INotificationManager notificationManager, IDeliveryFeesCalculator deliveryFeesCalculator)
        {
            this.dbContext = dbContext;
            this.notificationManager = notificationManager;
            this.deliveryFeesCalculator = deliveryFeesCalculator;
        }

        public async Task<CreationResult> PlaceOrder(Order order)
        {
            if (order is null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            // Replace with retrieving the customer from the database using order.CustomerId
            Customer customer = null;

            var deliveryFees = deliveryFeesCalculator.Calculate(order, customer);
            order.CalculateTotalPrice(deliveryFees);

            using var context = new AppDbContext();
            context.Orders.Add(order);
            await context.SaveChangesAsync();

            await notificationManager.Notify(new Message
            {
                RecipientId = order.CustomerId,
                Subject = "Order Placed!",
                Body = $"Congrats! Your order #{order.Id} has been placed successfully."
            });

            return new CreationResult
            {
                Success = true,
                OrderId = order.Id,
            };
        }
    }
}
