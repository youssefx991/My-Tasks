using Microsoft.EntityFrameworkCore;
using MySharedLibrary.Models;
namespace MyWebAPI.Models
{
    public class MainDBContext : DbContext 
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }

    }
}
