using System;

namespace DesafioPmenos.Infrastructure.Entity
{
    public class ProdutoEntity
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public float PrecoProduto { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
