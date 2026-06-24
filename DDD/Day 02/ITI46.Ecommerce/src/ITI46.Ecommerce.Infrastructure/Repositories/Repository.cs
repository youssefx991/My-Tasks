using ITI46.Ecommerce.Core.Base;
using ITI46.Ecommerce.Core.Ordering.Interfaces;

namespace ITI46.Ecommerce.Infrastructure.Repositories
{
    public class Repository<T, TId> : ReadRepository<T, TId>, IRepository<T, TId> where T : Entity<TId>, IAggregateRoot
    {
        public Repository(AppDbContext context) : base(context)
        {
        }

        public async Task<T> Insert(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
