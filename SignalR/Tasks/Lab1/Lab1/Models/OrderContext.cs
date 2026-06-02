using Microsoft.EntityFrameworkCore;

namespace Lab1.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext()
        {

        }

        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Order> Orders { get; set; }

    }
}
