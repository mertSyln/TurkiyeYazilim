using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Project1.Application.Dtos.LoginRegisterDtos;
using Project1.Application.Interfaces;

namespace Project1.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto request)
        {
            var result = await _userService.LoginAsync(request);
            return result ? Ok() : Unauthorized();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto request)
        {
            var result = await _userService.RegisterAsync(request);
            return result ? Ok() : BadRequest();
        }
            
    }
}
