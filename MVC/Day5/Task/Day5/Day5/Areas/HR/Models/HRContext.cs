using Microsoft.EntityFrameworkCore;


namespace Day5.Areas.HR.Models
{
    public class HRContext : DbContext
    {
        public HRContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLExpress;Initial Catalog=HR;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Department>? Departments { get; set; }
    }
}
