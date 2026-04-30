using Microsoft.EntityFrameworkCore;
using SD46API.Models;

namespace SD46API.Context
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=.;Database=SD46API;Trusted_Connection=True; Encrypt=False;");
        }
    
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employee { get; set; }

    }
}
