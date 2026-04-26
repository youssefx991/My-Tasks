using Day9.Models;

namespace Day9.RepoServices
{
    public interface ITraineeRepository
    {
        public List<Trainee> GetAll();
        public Trainee GetDetails(int id);
        public void Insert(Trainee trainee);
        public void UpdateTrainee(Trainee trainee);
        public void DeleteTrainee(int id);
    }
}
