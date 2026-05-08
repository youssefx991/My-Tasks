using Day1.Models;
using Day1.Repositories;

namespace Day1.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGenericRepo<Department> DepartmentRepo { get; }
        public IGenericRepo<Student> StudentRepo { get; }
        public Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
