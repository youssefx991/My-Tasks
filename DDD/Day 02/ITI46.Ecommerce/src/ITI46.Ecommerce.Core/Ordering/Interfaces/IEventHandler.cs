namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IEventHandler<T> where T : IEvent
    {
        Task Handle(T @event);
    }
}
