using BlazorWebAssemblyApp_46.RepoServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWebAssemblyApp_46
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);


            builder.RootComponents.Add<App>("#app");


            builder.RootComponents.Add<HeadOutlet>("head::after");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(
                 httpClient => httpClient.BaseAddress = new Uri("http://localhost:5199/")
                );

            builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(
                 httpClient => httpClient.BaseAddress = new Uri("http://localhost:5199/")
                );


            await builder.Build().RunAsync();
        }
    }
}
