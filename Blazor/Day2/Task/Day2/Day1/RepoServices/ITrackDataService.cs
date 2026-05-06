using MySharedLibrary.Models;

namespace Day1.RepoServices
{
    public interface ITrackDataService
    {
        public Task<IEnumerable<Track>> GetAllTracks();
        public  Task<Track> GetTrackByID(int id);

        public Task<Track> AddTrack(Track track);
        public Task UpdateTrack(Track track);
        public Task DeleteTrack(int id);

        public Task<string> GetTrackNameByID(int id);
    }
}
