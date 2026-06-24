using AOPAPI.BLL;
using AOPAPI.DAL;
using AOPAPI.Models;
using AOPAPI.MyAspects.Logging.Utilities;
using System.Diagnostics;

namespace AOPAPI.MyAspects.Logging.Decorator
{
    public class LoggingDecorator : IUserService
    {
        private readonly IUserService _userService;
        private readonly IApplicationLogger _logger;

        public LoggingDecorator(
            IUserService userService,
            IApplicationLogger logger)
        {
            _userService = userService;
            _logger = logger;
        }

        public bool AssignCourse(AssignCourseInput input)
        {
            return ExecuteWithLogging(
                nameof(AssignCourse),
                new object[] { input },
                () => _userService.AssignCourse(input));
        }

        public IEnumerable<User> GetAll()
        {
            return ExecuteWithLogging(
                nameof(GetAll),
                Array.Empty<object>(),
                () => _userService.GetAll());
        }

        public User GetById(int id)
        {
            return ExecuteWithLogging(
                nameof(GetById),
                new object[] { id },
                () => _userService.GetById(id));
        }

        private T ExecuteWithLogging<T>(
            string methodName,
            object[] parameters,
            Func<T> methodToExecute)
        {
            try
            {
                _logger.LogMethodEntry(methodName, parameters);

                var stopwatch = Stopwatch.StartNew();

                var result = methodToExecute();

                stopwatch.Stop();

                _logger.LogMethodExit(
                    methodName,
                    result,
                    stopwatch.ElapsedMilliseconds);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogMethodException(methodName, ex, 0);
                throw;
            }
        }
    }
}