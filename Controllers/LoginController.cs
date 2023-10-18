using DesafioBalta.Models;
using DesafioBalta.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBalta.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateNewUser(User model)
        {
            var user = await _userService.CreateAsync(model);
            if (user == null)
                return NotFound(new { message = "usuário ou senha inválidos" });

            return Ok(user);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(User user)
        {
            var databaseUser = await _userService.LoginUserAsync(user);
            if (databaseUser == null)
                return NotFound(new { message = "usuário ou senha inválidos" });

            return Ok(databaseUser);
        }

        [HttpGet]
        [Route("getAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();

            return Ok(users);
        }
    }
}