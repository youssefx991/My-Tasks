using ITI46.Ecommerce.Core.Base;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IReadRepository<T, TId> where T : Entity<TId>, IAggregateRoot
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(TId id);
    }
}
