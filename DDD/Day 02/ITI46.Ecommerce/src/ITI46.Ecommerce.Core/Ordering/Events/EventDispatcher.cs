using ITI46.Ecommerce.Core.Ordering.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ITI46.Ecommerce.Core.Ordering.Events
{
    public class EventDispatcher<T> : IEventDispatcher<T> where T : IEvent
    {
        private readonly IServiceProvider serviceProvider;

        public EventDispatcher(IServiceProvider serviceProvider) => this.serviceProvider = serviceProvider;

        public async Task Dispatch(T @event)
        {
            var services = serviceProvider.GetServices<IEventHandler<T>>();

            foreach (var service in services)
            {
                await service.Handle(@event);
            }
        }
    }
}
