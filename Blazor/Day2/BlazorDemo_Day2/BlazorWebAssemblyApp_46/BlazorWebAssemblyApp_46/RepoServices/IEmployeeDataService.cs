using MySharedLibrary;

namespace BlazorWebAssemblyApp_46.RepoServices
{
    public interface IEmployeeDataService
    {
        public Task<IEnumerable<Employee>> GetAllEmployees();
        public Task<Employee> GetEmployeeDetails(int id);
        public Task AddEmployee(Employee employee);
        public Task UpdateEmployee(Employee employee);
        public Task DeleteEmployee(int employeeId);
    }
}
