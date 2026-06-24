using AOPAPI.Aspects.BaseDecorator;
using AOPAPI.BLL;
using AOPAPI.DAL;
using AOPAPI.Models;

namespace AOPAPI.Aspects.Validation.Decorator
{
    /// <summary>
    /// Sudo code for new non functional requirement (validation) to demonstrate how to add new aspect
    /// </summary>
    public class UserServiceValidationDecorator : UserServiceBaseDecorator
    {

        public UserServiceValidationDecorator(IUserService userService) : base(userService)
        {

        }

        public override bool AssignCourse(AssignCourseInput input)
        {
            // Validation
            return base.AssignCourse(input);
        }

        public override IEnumerable<User> GetAll()
        {
            // Validation
            return base.GetAll();

        }

        public override User GetById(int id)
        {
            // Validation
            return base.GetById(id);

        }
    }
}
