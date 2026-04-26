using Microsoft.EntityFrameworkCore;
using Day9.ViewModels;
using Day9.Models;

namespace Day9.Models
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
