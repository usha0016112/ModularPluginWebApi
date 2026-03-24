using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PluginController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPlugins()
        {
            return Ok(new string[] { "Plugin1", "Plugin2" });
        }
    }
}