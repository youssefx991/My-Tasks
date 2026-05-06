using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD46API.Repo;

namespace SD46API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockController : ControllerBase
    {
        IDeptRepo db;
        public MockController([FromKeyedServices("test")] IDeptRepo _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult get()
        {
            return Ok(db.getAll());
        }
    }
}
