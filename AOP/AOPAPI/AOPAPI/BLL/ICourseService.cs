using AOPAPI.DAL;
using AOPAPI.Models;

namespace AOPAPI.BLL
{
    public interface ICourseService
    {
        bool Delete(DeleteCourseInput input);
        IEnumerable<Course> GetAll();
        Course GetById(int id);
    }
}
