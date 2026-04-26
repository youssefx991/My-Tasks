using Day9.Models;
using Day9.Models;
using Microsoft.EntityFrameworkCore;

namespace Day9.RepoServices
{
    public class TraineeCourseRepoService : ITraineeCourseRepository
    {
        public TraineeTracksCoursesContext Context { get; }

        public TraineeCourseRepoService(TraineeTracksCoursesContext context)
        {
            Context = context;
        }

        public void DeleteTraineeCourse(int traineeId, int courseId)
        {
            var traineeCourse = Context.TraineeCourses.Include(tc => tc.Trainee).Include(tc => tc.Course).FirstOrDefault(tc => tc.TraineeID == traineeId && tc.CourseID == courseId);
            if (traineeCourse != null)
            {
                Context.TraineeCourses.Remove(traineeCourse);
                Context.SaveChanges();
            }
        }
        public List<TraineeCourse> GetAll()
        {
            return Context.TraineeCourses.Include(tc => tc.Trainee).Include(tc => tc.Course).ToList();
        }

        public TraineeCourse GetDetails(int traineeId, int courseId)
        {
            return Context.TraineeCourses.Include(tc => tc.Trainee).Include(tc => tc.Course).FirstOrDefault(tc => tc.TraineeID == traineeId && tc.CourseID == courseId);
        }

        public void Insert(TraineeCourse traineeCourse)
        {
            Context.TraineeCourses.Add(traineeCourse);
            Context.SaveChanges();
        }

        public void UpdateTraineeCourse(TraineeCourse traineeCourse)
        {
            Context.TraineeCourses.Update(traineeCourse);
            Context.SaveChanges();
        }
    }
}
