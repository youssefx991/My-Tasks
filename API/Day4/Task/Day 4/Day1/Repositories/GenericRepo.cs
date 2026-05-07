using Day1.Models;

namespace Day1.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly StudentContext Context;

        public GenericRepo(StudentContext Context)
        {
            this.Context = Context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(int id)
        {
            var entity = GetByID(id);
            if (entity != null)
            {
                Context.Set<T>().Remove(entity);
                Save();
            }
        }

        public List<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            Save();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }

}
