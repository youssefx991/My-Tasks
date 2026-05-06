using MySharedLibrary.Models;
using System.Net.Http.Json;

namespace Day1.RepoServices
{
    public class TraineeDataService : ITraineeDataService
    {
        public HttpClient HttpClient { get; set; }
        public TraineeDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Trainee>> GetAllTrainees()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Trainee>>("api/trainee");
        }

        public async Task<Trainee> GetTraineeByID(int id)
        {
            return await HttpClient.GetFromJsonAsync<Trainee>($"api/trainee/{id}");
        }

        public async Task<Trainee> AddTrainee(Trainee trainee)
        {
            var response = await HttpClient.PostAsJsonAsync<Trainee>("api/trainee", trainee);
            return await response.Content.ReadFromJsonAsync<Trainee>();
        }

        public async Task UpdateTrainee(Trainee trainee)
        {
            await HttpClient.PutAsJsonAsync<Trainee>($"api/trainee/{trainee.ID}", trainee);
        }

        public async Task DeleteTrainee(int id)
        {
            await HttpClient.DeleteAsync($"api/trainee/{id}");
        }

        
    }
}
