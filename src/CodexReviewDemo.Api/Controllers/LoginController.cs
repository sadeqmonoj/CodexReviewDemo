using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodexReviewDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController() { }

        public IActionResult Login(string username, string password)
        {
            // This is a placeholder for actual authentication logic.
            // In a real application, you would validate the username and password against a database or an authentication service.
            if (username == "admin" && password == "password")
            {
                // Simulate successful login by returning a dummy token
                return Ok(new { Token = "dummy-jwt-token" });
            }
            else
            {
                // Simulate failed login
                return Unauthorized(new { Message = "Invalid username or password." });
            }
        }
    }
}
