using _7_NetCORE.Models;
using _7_NetCORE.RepoServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace _7_NetCORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // ------------------ DI Container ------------------
            // Add services to the container.
            builder.Services.AddControllersWithViews(
                //conf=>
                //conf.Filters.Add(new AuthorizeFilter()) 
                );

            // Register the DbContext with the DI container

            //anyone request service of type MainDbContext, create & inject obj of it using the options 

            builder.Services.AddDbContext<MainDbContext>(op =>
                //op.UseSqlServer("Data Source=.;Initial Catalog=RepoDb_46;Integrated Security=True;Trust Server Certificate=True")
                //op.UseSqlServer(builder.Configuration["ConnectionStrings:myConn"])
                op.UseSqlServer(builder.Configuration.GetConnectionString("myConn"))
                );


            // Register the repository services with the DI container
            //anyone request service of type IStudentRepository, create & inject obj of class "StudentRepoService", with Scoped lifetime
            builder.Services.AddScoped<IStudentRepository, StudentRepoService>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepoService>();


            //Add Identity services to the DI container, and specify that we want to use Entity Framework to store user information, and specify the DbContext to use for that
            
            builder.Services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<MainDbContext>();


            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthentication();
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

