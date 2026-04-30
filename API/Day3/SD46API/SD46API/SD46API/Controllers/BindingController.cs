using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD46API.Models;

namespace SD46API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BindingController : ControllerBase
    {
        [HttpPost("{Id?}/{Name?}")]
        public IActionResult TestPre( int id , [FromQuery] string? name)
        {
            return Ok(new { id, name });
        }
        [HttpPost]
        public IActionResult testComplex([FromQuery]Department dept,[FromBody]int id)
        {
            return Ok(dept);
        }
    }
}
