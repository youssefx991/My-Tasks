using _7_NetCORE.Models;
using _7_NetCORE.RepoServices;
using Microsoft.EntityFrameworkCore;

namespace _7_NetCORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<StdContext>( op =>
                  //op.UseSqlServer("Data Source=.;Initial Catalog=StDb_New;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                  //op.UseSqlServer(builder.Configuration["ConnectionStrings:myConn"])
                  op.UseSqlServer(builder.Configuration.GetConnectionString("myConn"))
                );

            builder.Services.AddScoped<IStudentRepository, StudentRepoService>();
            builder.Services.AddScoped<IDepartmentRepository , DepartmentRepoService>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
