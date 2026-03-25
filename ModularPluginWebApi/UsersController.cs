using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

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
            var users = new List<string>
            {
                "Naveen",
                "Kumar",
                "Arun"
            };

            return Ok(users);
        }
    }
}
