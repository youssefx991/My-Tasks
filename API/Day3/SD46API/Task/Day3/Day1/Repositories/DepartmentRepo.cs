using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly StudentContext Context;

        public DepartmentRepo(StudentContext Context)
        {
            this.Context = Context;
        }

        public void Add(Department entity)
        {
            Context.Departments.Add(entity);
            Save();
        }

        public void Delete(int id)
        {
            var department = GetByID(id);
            if (department != null)
                Context.Departments.Remove(department);
            Save();

        }

        public List<Department> GetAll()
        {
            return Context.Departments.ToList();
        }

        public Department GetByID(int id)
        {
            return Context.Departments.Find(id);
        }

        public void Update(Department entity)
        {
            Context.Departments.Update(entity);
            Save();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public List<Department> GetAllWithStudents()
        {
            return Context.Departments.Include(d => d.Students).ToList();
        }
    }
}
