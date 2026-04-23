using Day8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Day8.RepoServices
{
    public class TrackRepoService : ITrackRepository
    {
        public TraineeTracksCoursesContext Context { get; }

        public TrackRepoService(TraineeTracksCoursesContext context)
        {
            Context = context;
        }

        public List<Track> GetAll()
        {
            return Context.Tracks.Include(t=>t.Trainees).ToList();
        }

        public Track GetDetails(int id)
        {
            return Context.Tracks.Include(t => t.Trainees).FirstOrDefault(t=>t.ID == id);
        }

        public void Insert(Track track)
        {
            Context.Tracks.Add(track);
            Context.SaveChanges();
        }

        public void UpdateTrack(Track track)
        {
            Context.Tracks.Update(track);
            Context.SaveChanges();
        }
        public void DeleteTrack(int id)
        {

            var track = Context.Tracks.Find(id);
            if (track != null)
            {
                Context.Tracks.Remove(track);
                Context.SaveChanges();
            }
        }
    }
}
