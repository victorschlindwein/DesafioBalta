using DesafioBalta.Models;
using DesafioBalta.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Threading;

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
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var data = await _ibgeService.GetAllIbgeAsync(cancellationToken);
            if (data == null)
                return NotFound(new { message = "Nenhum dado encontrado" });

            return Ok(data);
        }

        [HttpPost]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var data = await _ibgeService.GetByIdAsync(id, cancellationToken);
            if (data == null)
                return NotFound(new { message = "Id não encontrado" });

            return Ok(data);
        }

        [HttpPost]
        [Route("GetByCity")]
        public async Task<IActionResult> GetByCity(string city, CancellationToken cancellationToken)
        {
            var data = await _ibgeService.GetCityIbge(city, cancellationToken);
            if (data.IsNullOrEmpty())
                return NotFound(new { message = "Cidade não encontrada" });

            return Ok(data);
        }

        [HttpPost]
        [Route("GetByState")]
        public async Task<IActionResult> GetByState(string state, CancellationToken cancellationToken)
        {
            var data = await _ibgeService.GetStateIbge(state, cancellationToken);
            if (data.IsNullOrEmpty())
                return NotFound(new { message = "Estado não encontrada" });

            return Ok(data);
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<IActionResult> UpdateIbge(int id, Ibge ibge)
        {
            var data = await _ibgeService.UpdateIbge(id, ibge);
            if (data == null)
                return NotFound(new { message = "Id inexistente na base de dados" });

            return Ok(data);
        }

        [HttpDelete]
        [Authorize]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _ibgeService.Delete(id);
            if (!data)
                return NotFound(new { message = "Id inexistente na base de dados "});

            return Ok(new { message = "Delete realizado com sucesso" });
        }
    }
}
