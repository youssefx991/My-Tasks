using ITI46.Ecommerce.Core.Interfaces;
using ITI46.Ecommerce.Core.Models;
using Microsoft.Extensions.Logging;

namespace ITI46.Ecommerce.Infrastructure.Notifications
{
    public class InAppNotificationManager : INotificationManager
    {
        private readonly ILogger<InAppNotificationManager> logger;

        public InAppNotificationManager(ILogger<InAppNotificationManager> logger) => this.logger = logger;
       
        public Task Notify(Message message)
        {
            // Some SignalR client code goes here

            logger.LogInformation($"{nameof(InAppNotificationManager)}: recipient: {message.RecipientId} Body: {message.Body}");

            return Task.CompletedTask;
        }
    }
}
