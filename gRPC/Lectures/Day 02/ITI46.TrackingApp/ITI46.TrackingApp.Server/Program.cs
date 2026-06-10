
using ITI46.TrackingApp.Server.Services;
using Microsoft.AspNetCore.Authentication;

namespace ITI46.TrackingApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddCors(opt => opt.AddPolicy("All", p =>
             p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
             .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding")));

            builder.Services.AddGrpc();
            builder.Services.AddGrpcReflection();

            builder.Services.AddAuthentication("BasicAuth")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuth", opt => { });

            builder.Services.AddAuthorization();

            var app = builder.Build();

            app.UseAuthentication();
            app.UseAuthorization();

            // Configure the HTTP request pipeline.
            app.UseCors();
            app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });
            app.MapGrpcService<LocationTrackingService>().RequireCors("All") ;//.EnableGrpcWeb();
            app.MapGrpcReflectionService();

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}
