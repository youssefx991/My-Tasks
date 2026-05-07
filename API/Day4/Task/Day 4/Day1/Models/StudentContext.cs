using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class StudentContext : IdentityDbContext<ApplicationUser>
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            
        }

        public  DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
