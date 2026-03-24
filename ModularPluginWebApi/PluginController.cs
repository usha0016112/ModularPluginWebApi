using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // 🔐 protected
    public class PluginController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Plugin data secured 🔐");
        }
    }
}