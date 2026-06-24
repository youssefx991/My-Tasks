using AOPAPI.BLL;
using AOPAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AOPAPI.Controllers
{
    [ApiController]
    [Route("api/Users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpPost("Assign")]
        public IActionResult Assign([FromBody] AssignCourseInput input)
        {
            var isAssigned = _userService.AssignCourse(input);
            return Ok(isAssigned);
        }
    }
}
