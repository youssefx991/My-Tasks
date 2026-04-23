using Day8.Models;

namespace Day8.RepoServices
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();
        public Course GetDetails(int id);
        public void Insert(Course course);
        public void UpdateCourse(Course course);
        public void DeleteCourse(int id);
    }
}
