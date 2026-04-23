using _7_NetCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace _7_NetCORE.RepoServices
{
    public class DepartmentRepoService : IDepartmentRepository
    {
        public StdContext Context { get; }
        public DepartmentRepoService(StdContext context)
        {
            Context = context;
        }

        public List<Department> GetAll()
        {
            return Context.Departments.ToList();
        }

        public Department GetDetails(int id)
        {
            return Context.Departments.FirstOrDefault(d => d.ID == id);
        }

        public void Insert(Department dept)
        {
            //if(ModelState.IsValid) //maynfa3sh nesta7'dmha hena 3shan di proprty lel Controller
            if (dept != null)
            {
                Context.Departments.Add(dept);
                Context.SaveChanges();
            }
        }

        public void UpdateDept(Department dept)
        {
            if (dept != null)
            {
                Context.Departments.Update(dept);
                Context.SaveChanges();
            }
        }

        public void DeleteDept(int id)
        {
            var dept = Context.Departments.Find(id);
            if (dept != null)
            {
                Context.Departments.Remove(dept);
                Context.SaveChanges();
            }
        }
    }
}
