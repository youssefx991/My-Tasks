using Microsoft.EntityFrameworkCore;
using _7_NetCORE.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace _7_NetCORE.Models
{
    public class MainDbContext:IdentityDbContext<AppUser> //DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options):base(options)
        {
            
        }

        public virtual DbSet<Student>  Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public DbSet<_7_NetCORE.ViewModels.StdDeptCrsLstViewModel> StdDeptCrsViewModel { get; set; } = default!;
        public DbSet<_7_NetCORE.ViewModels.UserViewModel> UserViewModel { get; set; } = default!;
        public DbSet<_7_NetCORE.ViewModels.LoginUserViewModel> LoginUserViewModel { get; set; } = default!;
    }
}
