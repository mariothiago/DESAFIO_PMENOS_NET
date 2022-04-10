using DesafioPmenos.Api.DTOs.Estoque;
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
    public class EstoqueLojaController : Controller
    {
        private IEstoqueLojaService _service;

        public EstoqueLojaController(IEstoqueLojaService service)
        {
            _service = service;
        }

        [HttpGet("obter-produtos-na-loja")]
        public async Task<IActionResult> GetProductsByStore([FromQuery] int idLoja)
        {
            try
            {
                var data = await _service.GetProductByStore(idLoja);

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

        [HttpGet("obter-lojas-com-produto")]
        public async Task<IActionResult> GetProductsInStores([FromQuery] int idProduto)
        {
            try
            {
                var data = await _service.GetProductsInStores(idProduto);

                if (data.Count() > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("criar-produto-estoque")]
        public async Task<IActionResult> InsertProductInStore([FromBody] CreateEstoqueDTO estoque)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                EstoqueLojaModel model = estoque.GetModel();
                var data = await _service.InsertProductInStore(model);

                if (data > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("excluir-estoque")]
        public async Task<IActionResult> DeleteProductOfStore([FromQuery] int idProduto, int idLoja)
        {
            try
            {
                var data = await _service.DeleteProductOfStore(idProduto, idLoja);

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
