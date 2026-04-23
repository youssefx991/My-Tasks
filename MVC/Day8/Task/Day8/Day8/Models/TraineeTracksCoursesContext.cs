using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Day8.Models
{
    public class TraineeTracksCoursesContext : DbContext
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
            modelBuilder.Entity<TraineeCourse>()
                .HasKey(tc => new { tc.TraineeID, tc.CourseID });
        }
    }
}
