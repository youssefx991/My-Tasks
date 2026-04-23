namespace Day6_46
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1.
            var builder = WebApplication.CreateBuilder(args); //Builder Pattern

            
            // ------------------------ Configure Services () -----------------------------
            // --------------------------- DI Container --------------------------------
            // ----------------------- Service Provider ---------------------------------

            //2.
            // Add services to the container.
            builder.Services.AddControllersWithViews();  //Add MVC services classes to DI container



            //3.

            var app = builder.Build();




            // --------------------------- Configure () --------------------------------
            // ----------------------- Middleware Pipeline ---------------------------------

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //Middleware for Exception Handling -- Development
                //Connection String to dummy DB
                //Static Files (Css, js, images, ....) ---> Local
            }

            if (app.Environment.IsProduction())
            {
                app.UseExceptionHandler("/Home/Error");  //Middleware for Exception Handling -- Production
                //Connection String to Final DB
                //Static Files (Css, js, images, ....) ---> CDN
            }


            app.UseRouting();  ///Middleware for Routing 

            app.UseAuthorization(); ///Middleware for Authorization

            app.MapStaticAssets();  //Middleware for Static Assets (Css, js, images, ....)

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            //5. Run
            app.Run(); //Middleware for Hosting (Kestrel Web Server)  -- terminal command to start the web application


        }
    }
}
