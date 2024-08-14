using Microsoft.AspNetCore.Mvc;
using TrainingCourses.IdentityService.Dtos;
using TrainingCourses.IdentityService.Services;
using TrainingCourses.Shared.BaseController;

namespace TrainingCourses.IdentityService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : CustomBaseController
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;


        public LoginController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }


        [HttpPost]
        public IActionResult Login([FromBody] User userInfo)
        {
            var user = _userService.Authenticate(userInfo.UserName, userInfo.Password);

            if (user == null)
                return Unauthorized("Invalid credentials");

            var token = _tokenService.GenerateToken(user);

            return Ok(new { Token = token });
        }

    }
}

