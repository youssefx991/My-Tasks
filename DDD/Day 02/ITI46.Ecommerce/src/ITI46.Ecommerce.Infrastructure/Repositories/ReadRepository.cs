using ITI46.Ecommerce.Core.Base;
using ITI46.Ecommerce.Core.Ordering.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITI46.Ecommerce.Infrastructure.Repositories
{
    public class ReadRepository<T, TId> : IReadRepository<T, TId> where T : Entity<TId>, IAggregateRoot
    {
        protected readonly AppDbContext context;

        public ReadRepository(AppDbContext context) => this.context = context;

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetById(TId id)
        {
            return await context.Set<T>().FirstOrDefaultAsync(item => item.Id.Equals(id));
        }
    }
}
