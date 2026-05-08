using Day1.Models;
using Day1.Repositories;

namespace Day1.UnitOfWork
{
    public class UnitOfWorkClass : IUnitOfWork
    {
        private readonly StudentContext Context;
        public IGenericRepo<Department> DepartmentRepo { get; }

        public IGenericRepo<Student> StudentRepo { get; }

        public UnitOfWorkClass(StudentContext context, IGenericRepo<Department> departmentRepo, IGenericRepo<Student> studentRepo)
        {
            Context = context;
            DepartmentRepo = departmentRepo;
            StudentRepo = studentRepo;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await Context.SaveChangesAsync(cancellationToken);
        }
    }
}
