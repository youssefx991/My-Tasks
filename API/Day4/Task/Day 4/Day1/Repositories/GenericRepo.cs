using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly StudentContext Context;

        public GenericRepo(StudentContext Context)
        {
            this.Context = Context;
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await Context.Set<T>().AddAsync(entity, cancellationToken);
            //Save();
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await Context.Set<T>().FindAsync(new object[] { id }, cancellationToken);
            if (entity != null)
            {
                Context.Set<T>().Remove(entity);
                //Save();
            }
        }

        public async Task<List<T>> GetAllAsync(string[] match = null, CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = Context.Set<T>();
            foreach (var item in match ?? Array.Empty<string>())
            {
                query = query.Include(item);
            }

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIDAsync(int id, CancellationToken cancellationToken = default)
        {
            return await Context.Set<T>().FindAsync(new object[] { id }, cancellationToken);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await Context.SaveChangesAsync(cancellationToken);
        }
    }

}
