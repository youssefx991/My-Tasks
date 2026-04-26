using Day9.Models;

namespace Day9.RepoServices
{
    public interface ITrackRepository
    {
        public List<Track> GetAll();
        public Track GetDetails(int id);
        public void Insert(Track track);
        public void UpdateTrack(Track track);
        public void DeleteTrack(int id);
    }
}
