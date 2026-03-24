using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            return Ok(new string[] { "User1", "User2", "User3" });
        }
    }
}