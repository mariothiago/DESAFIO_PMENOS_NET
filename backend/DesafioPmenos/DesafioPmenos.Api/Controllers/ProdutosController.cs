using DesafioPmenos.Api.DTOs;
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
    public class ProdutosController : Controller
    {
        private IProdutoService _service;
        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet("obter-pelo-id")]
        public async Task <IActionResult> GetProductByCode(int id)
        {
            try
            {
                var data = await _service.GetProductByCode(id);
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

        //[HttpGet("obter-por-loja")]
        //public Task<IActionResult> GetByStore(int id)
        //{

        //}

        //[HttpPost("criar-produto")]
        //public Task<IActionResult> CreateProduct(ProdutoCreateDTO produto)
        //{
        //    return Ok(produto);
        //}

        //[HttpPut("alterar-produto")]
        //public Task<IActionResult> UpdateProduct(ProdutoUpdateDTO produto)
        //{

        //}

        //[HttpDelete("excluir-produto")]
        //public Task<IActionResult> DeleteProduct(int id)
        //{

        //}
    }
}
