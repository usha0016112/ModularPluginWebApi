using Microsoft.AspNetCore.Mvc;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            var users = new List<object>
            {
                new { Id = 1, Name = "Naveen" },
                new { Id = 2, Name = "Praveen" }
            };

            return Ok(users);
        }
    }
}