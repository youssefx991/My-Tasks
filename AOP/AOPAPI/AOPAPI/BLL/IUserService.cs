using AOPAPI.DAL;
using AOPAPI.Models;

namespace AOPAPI.BLL
{
    public interface IUserService
    {
        bool AssignCourse(AssignCourseInput input);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
