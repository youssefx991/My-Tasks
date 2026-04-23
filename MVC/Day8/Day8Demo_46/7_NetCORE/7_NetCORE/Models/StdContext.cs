using Microsoft.EntityFrameworkCore;
using _7_NetCORE.ViewModels;

namespace _7_NetCORE.Models
{
    public class StdContext:DbContext
    {
        public StdContext(DbContextOptions<StdContext> options):base(options)
        {
            
        }

        public virtual DbSet<Student>  Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public DbSet<_7_NetCORE.ViewModels.StdDeptCrsViewModel> StdDeptCrsViewModel { get; set; } = default!;
    }
}
