
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SD46API.Context;
using SD46API.Filters;
using SD46API.Middlwares;
using SD46API.Models;
using SD46API.Repo;
using System.Text;

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

            builder.Services.AddDbContext<CompanyContext>(op =>
            {
                op.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(op =>
            {
                op.Password.RequireLowercase = false;
                op.Password.RequireNonAlphanumeric = false;
                op.Password.RequiredLength = 4;
            })
                .AddEntityFrameworkStores<CompanyContext>();

            //JWT Config
            builder.Services.AddAuthentication(op =>
            {
                op.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                op.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(op =>
            {
            op.TokenValidationParameters = new TokenValidationParameters(){
                ValidateAudience = true,
                ValidAudience = "http://localhost:5015/",
                ValidateIssuer = true,
                ValidIssuer = "http://localhost:5004/",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1fe9456a16ecee57f8a4755811fa3536473a9b11c48ada9acc8d988076f4d438"))
            };
            
            });












            builder.Services.AddScoped<IEmpRepo, EmpRepo>();
            builder.Services.AddKeyedScoped<IDeptRepo, DeptRepo>("real");
            builder.Services.AddKeyedScoped<IDeptRepo, MockTestRepo>("test");





            builder.Services.AddCors(op =>
            {
                //op.AddDefaultPolicy(o =>
                //o.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()
                //);
                op.AddPolicy("allowAll", o =>
                {
                    o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
                op.AddPolicy("Private", o =>
                {
                    o.WithOrigins("http://125.12.11.0").WithMethods("Get").WithHeaders("Authorization");
                });
                op.AddPolicy("PrivateEmp", o =>
                {
                    o.WithOrigins("http://125.12.11.0").WithMethods("Get").WithHeaders("Authorization");
                });
            });

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
            app.UseCors("Private");
            //app.MapControllerRoute(
            //    name: "def",
            //    pattern: "/dept",
            //    defaults: new { controller = "Department", action = "getAll" }
            //    );
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
