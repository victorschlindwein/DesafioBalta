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
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.Get(model.Email, model.Senha);

            if (user == null)
                return NotFound(new { message = "usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            user.Senha = "";

            return new { user, token };
        }
    }
}