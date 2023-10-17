using DesafioBalta.Models;
using DesafioBalta.Repositories;
using DesafioBalta.Services;
using Microsoft.AspNetCore.Mvc;
using System;

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

            var token = TokenService.GenerateToken(user);

            user.AcessToken = token;

            return Ok(user);
        }

        [HttpGet]
        [Route("getAllUsers")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();

            return Ok(users);
        }
    }
}