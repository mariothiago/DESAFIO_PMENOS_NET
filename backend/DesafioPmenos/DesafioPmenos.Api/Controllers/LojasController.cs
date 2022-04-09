using DesafioPmenos.Api.DTOs.Lojas;
using DesafioPmenos.Infrastructure.Model;
using DesafioPmenos.Infrastructure.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DesafioPmenos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojasController : Controller
    {
        private ILojaService _service;
        public LojasController(ILojaService service)
        {
            _service = service;
        }

        [HttpGet("obter-pelo-id")]
        public async Task<IActionResult> GetLojaById(int id)
        {
            try
            {
                var data = await _service.GetLojaById(id);

                if (data != null)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("obter-todas")]
        public async Task<IActionResult> GetAllLojas()
        {
            try
            {
                var data = await _service.GetAllLojas();

                if (data.Count() > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CreateLoja(CreateLojaDTO loja)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                LojaModel model = loja.GetModel();
                var data = await _service.CreateLoja(model);

                if (data > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("alterar")]
        public async Task<IActionResult> UpdateLoja(UpdateLojaDTO loja)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                LojaModel model = loja.GetModel();
                var data = await _service.UpdateLoja(model);

                if (data > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("excluir")]
        public async Task<IActionResult> DeleteLoja(int id)
        {
            try
            {
                var data = await _service.DeleteLoja(id);

                if (data > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
