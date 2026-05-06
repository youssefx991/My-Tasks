using MySharedLibrary.Models;
using System.Net.Http.Json;

namespace Day1.RepoServices
{
    public class TrackDataService : ITrackDataService
    {
        public HttpClient HttpClient { get; set; }
        public TrackDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Track>> GetAllTracks()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Track>>("api/track");
        }

        public async Task<Track> GetTrackByID(int id)
        {
            return await HttpClient.GetFromJsonAsync<Track>($"api/track/{id}");
        }

        public async Task<Track> AddTrack(Track track)
        {
            var response = await HttpClient.PostAsJsonAsync<Track>("api/track", track);
            return await response.Content.ReadFromJsonAsync<Track>();
        }

        public async Task UpdateTrack(Track track)
        {
            await HttpClient.PutAsJsonAsync<Track>($"api/track/{track.ID}", track);
        }

        public async Task DeleteTrack(int id)
        {
            await HttpClient.DeleteAsync($"api/track/{id}");
        }

        public async Task<string> GetTrackNameByID(int id)
        {
            var track = await HttpClient.GetFromJsonAsync<Track>($"api/track/{id}");
            return track.Name;
        }
    }
}
