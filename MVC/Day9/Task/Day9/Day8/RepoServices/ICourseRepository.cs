using Day9.Models;

namespace Day9.RepoServices
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
