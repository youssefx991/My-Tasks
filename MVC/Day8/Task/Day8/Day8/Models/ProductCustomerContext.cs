using Microsoft.EntityFrameworkCore;
using Day8.ViewModels;

namespace Day8.Models
{
    public class ProductCustomerContext : DbContext
    {
        public ProductCustomerContext(DbContextOptions<ProductCustomerContext> options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
