using ITI46.Ecommerce.Core.Interfaces;
using ITI46.Ecommerce.Core.Models;
using ITI46.Ecommerce.Core.Ordering.Events;
using ITI46.Ecommerce.Core.Ordering.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITI46.Ecommerce.Infrastructure.Notifications
{
    public class InAppNotificationManager : INotificationManager, IEventHandler<OrderCreatedEvent>
    {
        private readonly ILogger<InAppNotificationManager> logger;

        public InAppNotificationManager(ILogger<InAppNotificationManager> logger) => this.logger = logger;

        public async Task Handle(OrderCreatedEvent @event)
        {
            await Notify(new Message
            {
                RecipientId = @event.CustomerId,
                Subject = "Order Created",
                Body = $"Your order with id {@event.Id} has been created successfully with amount {@event.OrderAmount}"
            });
        }

        public Task Notify(Message message)
        {
            // Some SignalR client code goes here

            logger.LogInformation($"{nameof(InAppNotificationManager)}: recipient: {message.RecipientId} Body: {message.Body}");

            return Task.CompletedTask;
        }
    }
}
