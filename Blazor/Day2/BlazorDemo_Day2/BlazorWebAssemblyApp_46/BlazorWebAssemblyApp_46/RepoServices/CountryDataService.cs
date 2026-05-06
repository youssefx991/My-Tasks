using MySharedLibrary;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp_46.RepoServices
{
    public class CountryDataService : ICountryDataService
    {
        public HttpClient HttpClient { get; }
        public CountryDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Country>>("api/countries");
        }

        public async Task<Country> GetCountryDetails(int id)
        {
            return await HttpClient.GetFromJsonAsync<Country>("api/countries/" + id);
        }
    }
}
