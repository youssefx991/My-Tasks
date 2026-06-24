using ITI46.Ecommerce.Core.Base;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces
{
    public interface IRepository<T, TId> : IReadRepository<T, TId> where T : Entity<TId>, IAggregateRoot
    {
        Task<T> Insert(T entity);
    }
}
