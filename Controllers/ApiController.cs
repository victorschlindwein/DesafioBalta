using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBalta.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public string Authorized() => $"Autenticado com usuário @{User.Identity.Name}";
}
