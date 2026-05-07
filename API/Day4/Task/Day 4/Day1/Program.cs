
using Day1.DTOs;
using Day1.Filters;
using Day1.Mapping;
using Day1.Middlewares;
using Day1.Models;
using Day1.Repositories;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;
namespace Day1
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Log.Logger = new LoggerConfiguration()
             .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
             .CreateLogger();

            MapsterConfig.RegisterMapping();

            builder.Host.UseSerilog();
            // Add services to the container.

            builder.Services.AddControllers(op => op.Filters.Add<ExceptionHandleFilter>());
            //builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(op =>
            {
                op.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            builder.Services.AddDbContext<StudentContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
            builder.Services.AddSingleton(TypeAdapterConfig.GlobalSettings);
            builder.Services.AddScoped<IMapper, ServiceMapper>();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<StudentContext>()
                .AddDefaultTokenProviders();

            var jwtKey = builder.Configuration["Jwt:Key"];
            var jwtIssuer = builder.Configuration["Jwt:Issuer"];
            var jwtAudience = builder.Configuration["Jwt:Audience"];

            builder.Services.AddAuthentication(op =>
            {
                op.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                op.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(op =>
                {
                    op.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = true,
                        ValidAudience = jwtAudience,
                        ValidateIssuer = true,
                        ValidIssuer = jwtIssuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                        ValidateIssuerSigningKey = true
                    };
                });


            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                if (!await roleManager.RoleExistsAsync("Student"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Student"));
                }
            }
            app.UseLoggingMiddleware();
            app.UseExceptionHandleMiddleware();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowAll");
            app.UseAuthentication();
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