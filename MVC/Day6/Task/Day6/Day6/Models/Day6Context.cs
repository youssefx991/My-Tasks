using Microsoft.EntityFrameworkCore;

namespace Day6.Models
{
    public class Day6Context : DbContext
    {
        public Day6Context() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLExpress;Initial Catalog=MVCDay6;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
