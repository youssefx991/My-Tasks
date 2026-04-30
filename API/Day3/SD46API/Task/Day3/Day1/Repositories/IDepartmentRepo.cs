using Day1.Models;

namespace Day1.Repositories
{
    public interface IDepartmentRepo : IGenericRepo<Department>
    {
        List<Department> GetAllWithStudents();
    }
}
