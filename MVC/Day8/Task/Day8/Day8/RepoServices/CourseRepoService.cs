using Day8.Models;

namespace Day8.RepoServices
{
    public class CourseRepoService : ICourseRepository
    {
        public TraineeTracksCoursesContext Context { get; }

        public CourseRepoService(TraineeTracksCoursesContext context)
        {
            Context = context;
        }
        public void DeleteCourse(int id)
        {
            var course = Context.Courses.Find(id);
            if (course != null)
            {
                Context.Courses.Remove(course);
                Context.SaveChanges();
            }
        }

        public List<Course> GetAll()
        {
            return Context.Courses.ToList();
        }

        public Course GetDetails(int id)
        {
            return Context.Courses.Find(id);
        }

        public void Insert(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            Context.Courses.Update(course);
            Context.SaveChanges();
        }
    }
}
