using DesafioPmenos.Infrastructure.Model;
using System;

namespace DesafioPmenos.Api.DTOs
{
    public class ProdutoCreateDTO
    {
        public string DescricaoProduto { get; set; }
        public float PrecoProduto { get; set; }

        public ProdutoModel GetModel()
        {
            return new ProdutoModel()
            {
                DataAlteracao = DateTime.Now,
                DescricaoProduto = DescricaoProduto,
                PrecoProduto = PrecoProduto
            };
        }
    }
}
