using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SD46API.Models;

namespace SD46API.Context
{
    public class CompanyContext :IdentityDbContext<ApplicationUser> //DbContext
    {
        public CompanyContext(DbContextOptions op):base(op)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("Server=.;Database=SD46API;Trusted_Connection=True; Encrypt=False;");
        //}
    
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employee { get; set; }

    }
}
