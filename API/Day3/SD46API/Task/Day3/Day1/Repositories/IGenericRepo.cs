namespace Day1.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        List<T> GetAll();
        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
