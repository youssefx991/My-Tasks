using AOPAPI.Aspects.Logging.Decorator;
using AOPAPI.Aspects.Logging.Interceptor;
using AOPAPI.Aspects.Logging.Utilities;
using AOPAPI.Aspects.Validation.Decorator;
using AOPAPI.Aspects.Validation.Interceptor;
using AOPAPI.BLL;
using AOPAPI.DAL;
using AOPAPI.DAL.Repositories;
using Castle.DynamicProxy;

namespace AOPAPI.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<Context>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseService, CourseService>();
           
            services.AddScoped<ILogger, Log4NetLogger>();

            #region User service with decorator
            //services.AddScoped<UserService>();
            //services.AddScoped<IUserService>(
            //    sp =>
            //    {
            //        IUserService core = sp.GetRequiredService<UserService>();
            //        IUserService validatedService = new UserServiceValidationDecorator(core);
            //        IUserService loggedService = new UserServiceLoggingDecorator(validatedService, sp.GetRequiredService<ILogger>());
            //        return loggedService;
            //    }
            //    );
            #endregion

            #region User Service with Interception
            //services.AddScoped<UserService>();
            //services.AddSingleton<IProxyGenerator>(new ProxyGenerator());
            //services.AddScoped<LoggingInterceptor>();
            //services.AddScoped<ValidationInterceptor>();
            //services.AddScoped<IUserService>(sp =>
            //{
            //    var generator = sp.GetRequiredService<IProxyGenerator>();
            //    var target = sp.GetRequiredService<UserService>();
            //    IInterceptor[] interceptors = [
            //        sp.GetRequiredService<LoggingInterceptor>(),
            //        sp.GetRequiredService<ValidationInterceptor>()
            //        ];

            //    return generator.CreateInterfaceProxyWithTarget<IUserService>(target, interceptors);
            //});
            #endregion

            #region User service Directly
            services.AddScoped<IUserService, UserService>();
            #endregion
            return services;
        }
    }
}
