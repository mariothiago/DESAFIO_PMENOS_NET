using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPmenos.Api.DTOs.Estoque
{
    public class CreateEstoqueDTO
    {
        public int IdLoja { get; set; }
        public int IdProduto { get; set; }

        public EstoqueLojaModel GetModel()
        {
            return new EstoqueLojaModel()
            {
                IdLoja = IdLoja,
                IdProduto = IdProduto
            };
        }
    }
}
