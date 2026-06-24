namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IEventDispatcher<TEvent> where TEvent : IEvent
    {
        Task Dispatch(TEvent @event);
    }
}
