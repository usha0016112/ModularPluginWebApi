using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]   // 🔐 IMPORTANT
    public class UsersController : ControllerBase
    {
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            return Ok(new { message = "Authorized users data" });
        }
    }
}