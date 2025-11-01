using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotorsWiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        public async Task<IActionResult> GetHello()
        {
            return Ok("Hello, World!");
        }
    }
}
