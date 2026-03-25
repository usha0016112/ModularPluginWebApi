using Microsoft.AspNetCore.Mvc;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExtraController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Extra controller working");
        }
    }
}