using Day8.Models;
using Microsoft.EntityFrameworkCore;

namespace Day8.RepoServices
{
    public class TraineeRepoService : ITraineeRepository
    {
        public TraineeTracksCoursesContext Context { get; }

        public TraineeRepoService(TraineeTracksCoursesContext context)
        {
            Context = context;
        }
        public void DeleteTrainee(int id)
        {
            var trainee = Context.Trainees.Find(id);
            if (trainee != null)
            {
                Context.Trainees.Remove(trainee);
                Context.SaveChanges();
            }
        }

        public List<Trainee> GetAll()
        {
            return Context.Trainees.Include(t=>t.Trk).ToList();
        }

        public Trainee GetDetails(int id)
        {
            return Context.Trainees.AsNoTracking().Include(t => t.Trk).FirstOrDefault(t => t.ID == id);
        }

        public void Insert(Trainee trainee)
        {
            Context.Trainees.Add(trainee); 
            Context.SaveChanges();
        }

        public void UpdateTrainee(Trainee trainee)
        {
            var editedTrainee = Context.Trainees.FirstOrDefault(t => t.ID == trainee.ID);
            if (editedTrainee != null)
            {
                editedTrainee.Name = trainee.Name;
                editedTrainee.Gender = trainee.Gender;
                editedTrainee.Email = trainee.Email;
                editedTrainee.MobileNo = trainee.MobileNo;
                editedTrainee.Birthdate = trainee.Birthdate;
                editedTrainee.TrackID = trainee.TrackID;
                Context.SaveChanges();
            }
        }
    }
}
