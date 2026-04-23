using _7_NetCORE.Models;

namespace _7_NetCORE.RepoServices
{
    public interface IDepartmentRepository
    {
        public List<Department> GetAll();
        public Department GetDetails(int id);
        public void Insert(Department dept);
        public void UpdateDept(Department dept);
        public void DeleteDept(int id);
    }
}
