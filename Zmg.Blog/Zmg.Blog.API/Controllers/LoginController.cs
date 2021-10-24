using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zmg.Blog.API.Resources;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly UserManager<User> _userManager;

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginResource login)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.UserName == login.Username);

            if (user == null)
            {
                return NotFound("User not found");
            }

            var userSigninResult = await _userManager.CheckPasswordAsync(user, login.Password);

            if (userSigninResult)
            {
                return Ok();
            }

            return BadRequest("Email or password incorrect");
        }
    }
}
