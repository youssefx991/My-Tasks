namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IEvent
    {
        string EventName { get; }

        DateTime CreateOn { get; }
    }
}
