using AOPAPI.Aspects.BaseDecorator;
using AOPAPI.BLL;
using AOPAPI.DAL;
using AOPAPI.Models;

namespace AOPAPI.Aspects.Logging.Decorator
{
    public class UserServiceLoggingDecorator : UserServiceBaseDecorator
    {
        private readonly ILogger _logger;

        public UserServiceLoggingDecorator(IUserService userService, ILogger logger) : base(userService)
        {
            _logger = logger;
        }

        public override bool AssignCourse(AssignCourseInput input)
        {
            try
            {
                return base.AssignCourse(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw;
            }
        }

        public override IEnumerable<User> GetAll()
        {
            try
            {
                return base.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw;
            }
        }

        public override User GetById(int id)
        {
            try
            {
                return base.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw;
            }
        }
    }
}
