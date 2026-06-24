using AOPAPI.Aspects.Logging.PostSharp;
using AOPAPI.DAL;
using AOPAPI.DAL.Repositories;
using AOPAPI.Models;
using AOPAPI.MyAspects.Logging.PostSharp;
using log4net;
using log4net.Config;
using System.Reflection;

namespace AOPAPI.BLL
{
    [MyAspects.Logging.PostSharp.LoggingAspect]
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICourseRepository _courseRepository;
        //private readonly ILogger _logger;

        public UserService(
            IUserRepository userRepository,
            ICourseRepository courseRepository
            //ILogger logger
            )
        {
            _userRepository = userRepository;
            _courseRepository = courseRepository;
            //_logger = logger;
        }

        public IEnumerable<User> GetAll()
        {
            var users = _userRepository.GetAll();
            return users;
        }

        public User GetById(int id)
        {
            //try
            //{

            var user = _userRepository.GetById(id);
            // Intentionally thrown to demonstrate that the logging aspect.
            throw new Exception("Test");
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex);
            //    throw;
            //}
        }

        public bool AssignCourse(AssignCourseInput input)
        {
            var user = _userRepository.GetById(input.UserId);
            var course = _courseRepository.GetById(input.CourseId);
            return _userRepository.AssignCourse(user, course);
        }

        private void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
