using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ModularPluginWebApi.Controllers
{
    [Authorize] // 🔐 Secure pannum
    [ApiController]
    [Route("api/[controller]")]
    public class PluginController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPlugins()
        {
            var plugins = new List<string>
            {
                "Plugin1",
                "Plugin2"
            };

            return Ok(plugins);
        }
    }
}