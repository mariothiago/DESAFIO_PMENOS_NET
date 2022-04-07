using System;

namespace DesafioPmenos.Infrastructure.Model
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public float PrecoProduto { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
