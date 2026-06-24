using ITI46.Ecommerce.Core.Models;

namespace ITI46.Ecommerce.Core.Interfaces
{
    public interface INotificationManager
    {
        Task Notify(Message message);
    }
}
