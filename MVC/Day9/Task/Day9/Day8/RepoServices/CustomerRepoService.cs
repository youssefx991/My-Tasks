using Day9.Models;
using Day9.Models;
using Microsoft.EntityFrameworkCore;

namespace Day9.RepoServices
{
    public class CustomerRepoService : ICustomerRepository
    {
        ProductCustomerContext Context { get; }
        public CustomerRepoService(ProductCustomerContext context)
        {
            Context = context;
        }
        public void DeleteCustomer(int id)
        {
           var customer = Context.Customers.Find(id);
            if (customer != null)
            {
                Context.Customers.Remove(customer);
                Context.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            return Context.Customers.Include(c=>c.Products).ToList();
        }

        public Customer GetDetails(int id)
        {
            return Context.Customers.Include(c => c.Products).FirstOrDefault(c => c.ID == id);
        }

        public void Insert(Customer customer)
        {
            Context.Customers.Add(customer);
            Context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            Context.Customers.Update(customer);
            Context.SaveChanges();
        }
    }
}
