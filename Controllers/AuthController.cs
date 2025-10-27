using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using dbmarket.Entities;
using dbmarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;


namespace dbmarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IConfiguration configuration) : ControllerBase
    {

        public static User user = new();
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            var hashedPassword = new PasswordHasher<User>()
            .HashPassword(user, request.Password);

            user.Username = request.Username;
            user.PasswordHash = hashedPassword;

            return Ok(user);
        }
        [HttpPost("login")]
        public ActionResult<string> Login(UserDto request)
        {
            if (user.Username != request.Username)
            {
                return BadRequest("User not found");
            }
            if (new PasswordHasher<User>().VerifyHashedPassword(user, user.PasswordHash, request.Password)
            == PasswordVerificationResult.Failed)
            {
                return BadRequest("Wrong password.");
            }

            string token = CreateToken(user);
            return Ok(token);
        }

        private string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
            };
            var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(configuration.GetValue<string>("AppSettings: Token")!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);
        }
    }
}