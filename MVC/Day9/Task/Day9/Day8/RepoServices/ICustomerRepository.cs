using Day9.Models;

namespace Day9.RepoServices
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();
        public Customer GetDetails(int id);
        public void Insert(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(int id);
    }
}
