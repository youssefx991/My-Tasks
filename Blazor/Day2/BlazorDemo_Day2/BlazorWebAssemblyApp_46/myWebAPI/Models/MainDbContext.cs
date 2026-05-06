using Microsoft.EntityFrameworkCore;
using MySharedLibrary;

namespace myWebAPI.Models
{
    public class MainDbContext:DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options) 
        {
            
        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

    }
}
