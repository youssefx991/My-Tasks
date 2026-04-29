
using Day1.Filters;
using Day1.Middlewares;
using Serilog;
namespace Day1
{
    public class Program
    {
         
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Log.Logger = new LoggerConfiguration()
             .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
             .CreateLogger();

            builder.Host.UseSerilog();
            // Add services to the container.

            //builder.Services.AddControllers(op=>op.Filters.Add<ExceptionHandleFilter>());
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseLoggingMiddleware();
            app.UseExceptionHandleMiddleware();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();

            //app.Use(async (context, next) =>
            //{
            //    throw new Exception("Exception in Custom Middleware");
            //    await next();

            //});
            
            app.Run();
        }
    }
}


/*
 * when filter is global, filter wins
 * when filter is applied on all actions for same controller,
 * when filter is applied on certain action, filter wins
 * 
 * when there is exception in middleware pipeline, middleware wins
 * when exception could not be handled in filter , middleware wins
 */