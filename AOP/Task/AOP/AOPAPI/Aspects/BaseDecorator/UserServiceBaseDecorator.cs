using AOPAPI.BLL;
using AOPAPI.DAL;
using AOPAPI.Models;

namespace AOPAPI.Aspects.BaseDecorator
{
    public class UserServiceBaseDecorator : IUserService
    {
        private readonly IUserService _userService;
        public UserServiceBaseDecorator(IUserService userService)
        {
            _userService = userService;
        }
        public virtual bool AssignCourse(AssignCourseInput input)
        {
            return _userService.AssignCourse(input);
        }

        public virtual IEnumerable<User> GetAll()
        {
            return _userService.GetAll();
        }

        public virtual User GetById(int id)
        {
            return _userService.GetById(id);
        }
    }
}
