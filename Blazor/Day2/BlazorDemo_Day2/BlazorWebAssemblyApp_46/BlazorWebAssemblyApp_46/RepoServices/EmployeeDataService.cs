using MySharedLibrary;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp_46.RepoServices
{
    public class EmployeeDataService : IEmployeeDataService
    {
        //HttpClient httpClient = new HttpClient("baseAddress");

        //request service of type HttpClient in the constructor 
        public HttpClient HttpClient { get; }
        public EmployeeDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/employees");
        }

        public async Task<Employee> GetEmployeeDetails(int id)
        {
            return await HttpClient.GetFromJsonAsync<Employee>("api/employees/" + id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await HttpClient.PutAsJsonAsync<Employee>("api/employees/" , employee);
        }

        public async Task AddEmployee(Employee employee)
        {
            await HttpClient.PostAsJsonAsync<Employee>("api/employees", employee);
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await HttpClient.DeleteAsync("api/employees/" + employeeId);
        }
    }
}
