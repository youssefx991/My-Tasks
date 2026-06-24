using AOPAPI.Aspects.Logging.Decorator;
using AOPAPI.Aspects.Logging.Interceptor;
using AOPAPI.Aspects.Logging.Utilities;
using AOPAPI.Aspects.Validation.Decorator;
using AOPAPI.Aspects.Validation.Interceptor;
using AOPAPI.BLL;
using AOPAPI.DAL;
using AOPAPI.DAL.Repositories;
using AOPAPI.MyAspects.Logging.Decorator;
using AOPAPI.MyAspects.Logging.Interceptor;
using AOPAPI.MyAspects.Logging.Utilities;
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

            services.AddScoped<AOPAPI.Aspects.Logging.Utilities.ILogger, AOPAPI.Aspects.Logging.Utilities.Log4NetLogger>();
            services.AddScoped<AOPAPI.MyAspects.Logging.Utilities.IApplicationLogger, AOPAPI.MyAspects.Logging.Utilities.Log4NetApplicationLogger>();

            #region User service with decorator (Original Aspects)
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

            #region User Service with Interception (Original Aspects)
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

            #region Enhanced User service with Decorator (MyAspects) - Logs parameters, return value, execution time
            //services.AddScoped<UserService>();
            //services.AddScoped<IUserService>(sp =>
            //{
            //    var core = sp.GetRequiredService<UserService>();
            //    var logger = sp.GetRequiredService<AOPAPI.MyAspects.Logging.Utilities.ILogger>();
            //    return new EnhancedUserServiceLoggingDecorator(core, logger);
            //});
            #endregion

            #region Enhanced User Service with Castle DynamicProxy Interceptor (MyAspects) - Logs parameters, return value, execution time
            //services.AddScoped<UserService>();
            //services.AddSingleton<IProxyGenerator>(new ProxyGenerator());
            //services.AddScoped<EnhancedLoggingInterceptor>();
            //services.AddScoped<IUserService>(sp =>
            //{
            //    var generator = sp.GetRequiredService<IProxyGenerator>();
            //    var target = sp.GetRequiredService<UserService>();
            //    var interceptor = sp.GetRequiredService<EnhancedLoggingInterceptor>();
            //    return generator.CreateInterfaceProxyWithTarget<IUserService>(target, interceptor);
            //});
            #endregion

            #region Enhanced User service with PostSharp Aspect (MyAspects) - Logs parameters, return value, execution time
            // To use PostSharp aspect, apply [EnhancedLoggingAspect] attribute to UserService class
            // Usage: 
            // [EnhancedLoggingAspect]
            // public class UserService : IUserService { ... }
            services.AddScoped<IUserService, UserService>();
            #endregion

            return services;
        }
    }
}
