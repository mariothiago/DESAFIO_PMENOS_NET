using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPmenos.Api.DTOs.Produtos
{
    public class ProdutoStoreCreateDTO
    {
        public int IdProduto { get; set; }
        public int IdLoja { get; set; }
        public string DescricaoProduto { get; set; }
        public float PrecoProduto { get; set; }
    }
}
