using MySharedLibrary.Models;

namespace Day1.RepoServices
{
    public interface ITraineeDataService
    {
        public Task<IEnumerable<Trainee>> GetAllTrainees();

        public Task<Trainee> GetTraineeByID(int id);

        public Task UpdateTrainee(Trainee trainee);

        public Task<Trainee> AddTrainee(Trainee trainee);

        public Task DeleteTrainee(int id);
    }
}
