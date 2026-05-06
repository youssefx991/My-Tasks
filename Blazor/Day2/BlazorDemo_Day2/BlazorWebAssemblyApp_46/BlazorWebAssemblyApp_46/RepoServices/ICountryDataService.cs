using MySharedLibrary;

namespace BlazorWebAssemblyApp_46.RepoServices
{
    public interface ICountryDataService
    {
        public Task<IEnumerable<Country>> GetAllCountries();
        public Task<Country> GetCountryDetails(int id);
    }
}
