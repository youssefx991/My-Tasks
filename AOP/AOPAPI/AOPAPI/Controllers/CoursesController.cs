using AOPAPI.BLL;
using AOPAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AOPAPI.Controllers
{
    [ApiController]
    [Route("api/Courses")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = _courseService.GetAll();
            return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourse(int id)
        {
            var course = _courseService.GetById(id);
            return Ok(course);
        }

        [HttpDelete("Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var input = new DeleteCourseInput() { CourseId = id };
            var isDeleted = _courseService.Delete(input);
            return Ok(isDeleted);
        }
    }
}
