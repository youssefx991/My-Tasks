using Day8.Models;
using Day8.RepoServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TraineeTracksCoursesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TraineeTracksCourses")));
builder.Services.AddDbContext<ProductCustomerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductsCustomers")));

builder.Services.AddScoped<ITrackRepository, TrackRepoService>();
builder.Services.AddScoped<ITraineeRepository, TraineeRepoService>();
builder.Services.AddScoped<ICourseRepository, CourseRepoService>();
builder.Services.AddScoped<ITraineeCourseRepository, TraineeCourseRepoService>();

builder.Services.AddScoped<IProductRepository, ProductRepoService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepoService>();

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
