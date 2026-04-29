
using Microsoft.AspNetCore.Mvc.Diagnostics;
using SD46API.Filters;
using SD46API.Middlwares;

namespace SD46API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(op=>op.Filters.Add<HandleExceptionFilterAttribute>());
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();
           // app.UseMiddleware<LoggingMiddleware>();
            app.UseLogging();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            #region CustomMiddleware
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Before Middleware 1 \n");
            //    await next();
            //    Console.WriteLine("After Middleware 1\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Before Middleware 2 \n");
            //    await next();
            //    Console.WriteLine("After Middleware 2\n");
            //});
            //app.MapGet("/hello", () => "Hello World!");
            //app.Run(async(context) =>
            //{
            //    Console.WriteLine("Terminate");
            //}); 
            #endregion

            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
