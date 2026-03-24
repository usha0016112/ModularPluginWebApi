using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]   // 🔐 IMPORTANT
    public class PluginController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPlugins()
        {
            return Ok(new { message = "Plugins loaded successfully" });
        }
    }
}