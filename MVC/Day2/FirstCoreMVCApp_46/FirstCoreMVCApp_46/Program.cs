namespace FirstCoreMVCApp_46
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseRouting();  // Enable Routing - Generate Routing table

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "otherRoute",
                pattern: "testtt",
                defaults: new { controller = "Test", action = "testAction" });

            app.MapControllerRoute(
                name: "myRoute",
                pattern: "MVC/SD/{*a}",
                defaults: new { controller = "Employee", action = "get" });

            app.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
