using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ModularPluginWebApi.Controllers
{
    [Authorize] // 🔐 Secure pannum
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
            return Ok("Extra API running (secured)");
        }
    }
}