using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ModularPluginWebApi.Controllers
{
    [Authorize] // 🔐 Secure pannum
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            var users = new List<string>
            {
                "Naveen",
                "Kumar",
                "Arun"
            };

            return Ok(users);
        }

        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok("Users API working (secured)");
        }
    }
}