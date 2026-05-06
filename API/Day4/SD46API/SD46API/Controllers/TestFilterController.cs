using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD46API.Filters;

namespace SD46API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 //   [HandleExceptionFilter]
    public class TestFilterController : ControllerBase
    {
        [HttpGet]
     
        public IActionResult act1()
        {
           throw new NotImplementedException();
        }
        [HttpGet("2")]
        public IActionResult act2()
        {
            throw new NotImplementedException();
        }
    }
}
