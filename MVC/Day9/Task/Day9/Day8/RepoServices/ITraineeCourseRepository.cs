using Day9.Models;

namespace Day9.RepoServices
{
    public interface ITraineeCourseRepository
    {
        public List<TraineeCourse> GetAll();
        public TraineeCourse GetDetails(int traineeId, int courseId);
        public void Insert(TraineeCourse traineeCourse);
        public void UpdateTraineeCourse(TraineeCourse traineeCourse);
        public void DeleteTraineeCourse(int traineeId, int courseId);
    }
}
