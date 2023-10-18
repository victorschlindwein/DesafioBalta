using DesafioBalta.Models;
using DesafioBalta.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DesafioBalta.Controllers
{
    [ApiController]
    [Route("ibge")]
    public class IbgeController : ControllerBase
    {
        private readonly IIbgeService _ibgeService;

        public IbgeController(IIbgeService ibgeService)
        {
            _ibgeService = ibgeService;
        }

        [HttpPost]
        [Authorize]
        [Route("create")]
        public async Task<IActionResult> CreateNew(Ibge ibge)
        {
            var data = await _ibgeService.CreateIbgeAsync(ibge);
            if (data == null)
                return BadRequest();

            return Ok(data);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _ibgeService.GetAllIbgeAsync();
            if (data == null)
                return NotFound(new { message = "Nenhum dado encontrado" });

            return Ok(data);
        }

        [HttpPost]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _ibgeService.GetByIdAsync(id);
            if (data == null)
                return NotFound(new { message = "Id não encontrado" });

            return Ok(data);
        }

        [HttpPost]
        [Route("GetByCity")]
        public async Task<IActionResult> GetByCity(string city)
        {
            var data = await _ibgeService.GetCityIbge(city);
            if (data.IsNullOrEmpty())
                return NotFound(new { message = "Cidade desconhecida" });

            return Ok(data);
        }

        [HttpPost]
        [Route("GetByState")]
        public async Task<IActionResult> GetByState(string state)
        {
            var data = await _ibgeService.GetStateIbge(state);
            if (data.IsNullOrEmpty())
                return NotFound(new { message = "Estado desconhecido" });

            return Ok(data);
        }

        [HttpDelete]
        [Authorize]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _ibgeService.Delete(id);
            if (!data)
                return BadRequest();

            return Ok(new { message = "Operação realizada com sucesso" });
        }
    }
}
