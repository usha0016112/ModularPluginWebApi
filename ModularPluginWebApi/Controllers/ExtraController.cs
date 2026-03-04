using Microsoft.AspNetCore.Mvc;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExtraController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("Hello from Extra Controller");
        }

        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok("Application is running...");
        }
    }
}