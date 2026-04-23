using _7_NetCORE.Models;

namespace _7_NetCORE.RepoServices
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
        public Student GetDetails(int id);
        public void Insert(Student std);
        public void UpdateStd(Student std);
        public void DeleteStd(int id);

    }
}
