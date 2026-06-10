
using Lab1.OrderingSystem.OrderService.API.Server.Services;

namespace Lab1.OrderingSystem.OrderService.API.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
                });
            });

            // Add services to the container.
            builder.Services.AddGrpc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseCors();
            app.UseGrpcWeb(new GrpcWebOptions
            {
                DefaultEnabled = true
            });

            
            app.MapGrpcService<Lab1.OrderingSystem.OrderService.API.Server.Services.OrderService>().RequireCors("AllowAll");

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}
