namespace Day1.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        Task<List<T>> GetAllAsync(string[] match = null, CancellationToken cancellationToken = default);
        Task<T?> GetByIDAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        public void Update(T entity);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
