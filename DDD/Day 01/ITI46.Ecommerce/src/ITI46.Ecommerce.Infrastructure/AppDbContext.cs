using ITI46.Ecommerce.Core.Ordering.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI46.Ecommerce.Infrastructure
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EcommerceDb");
        }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderItem> OrderItems { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
