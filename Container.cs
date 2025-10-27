using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dbmarket.Entities;
using dbmarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dbmarket
{
    [Route("[controller]")]
    [ApiController]
    public class Container : Controller
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
    }
}
