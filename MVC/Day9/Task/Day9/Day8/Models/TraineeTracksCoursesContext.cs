using Day9.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Day9.ViewModels;

namespace Day9.Models
{
    public class TraineeTracksCoursesContext : IdentityDbContext<Client>
    {
        public TraineeTracksCoursesContext(DbContextOptions<TraineeTracksCoursesContext> options) : base(options)
        {
        }

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<TraineeCourse> TraineeCourses { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TraineeCourse>()
                .HasKey(tc => new { tc.TraineeID, tc.CourseID });
        }
        public DbSet<Day9.ViewModels.RegisterUserViewModel> RegisterUserViewModel { get; set; } = default!;
        public DbSet<Day9.ViewModels.LoginUserViewModel> LoginUserViewModel { get; set; } = default!;
    }
}
