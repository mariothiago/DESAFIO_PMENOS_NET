using DesafioPmenos.Api.DTOs.Clientes;
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
    public class ClienteController : Controller
    {
        private IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet("obter-pelo-id")]
        public async Task<IActionResult> GetClientById(int id)
        {
            try
            {
                var data = await _service.GetClientById(id);

                if (data != null)
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
        public async Task<IActionResult> CreateClient(CreateClienteDTO cliente)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                ClienteModel model = cliente.GetModel();
                var data = await _service.CreateClient(model);

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
        public async Task<IActionResult> UpdateClient(UpdateClienteDTO cliente)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                ClienteModel model = cliente.GetModel();
                var data = await _service.UpdateClient(model);

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
        public async Task<IActionResult> DeleteClient(int id)
        {
            try
            {
                var data = await _service.DeleteClient(id);
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
