using Microsoft.EntityFrameworkCore;
using Day6_46.Models;

namespace Day6_46.Models
{
    public class StdDbContext:DbContext
    {
        public StdDbContext():base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StdDb_46;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Student> Students  { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public DbSet<Day6_46.Models.Employee> Employee { get; set; } = default!;

    }
}
