using DesafioPmenos.Infrastructure.Model;
using System;

namespace DesafioPmenos.Api.DTOs
{
    public class ProdutoUpdateDTO
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public float PrecoProduto { get; set; }

        public ProdutoModel GetModel()
        {
            return new ProdutoModel()
            {
                DataAlteracao = DateTime.Now,
                DescricaoProduto = DescricaoProduto,
                PrecoProduto = PrecoProduto,
                IdProduto = IdProduto
            };
        }
    }
}
