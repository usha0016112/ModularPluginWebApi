using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Authorize] // 🔐 IMPORTANT
public class UsersController : ControllerBase
{
    [HttpGet("getusers")]
    public IActionResult GetUsers()
    {
        return Ok(new { users = new[] { "User1", "User2" } });
    }
}