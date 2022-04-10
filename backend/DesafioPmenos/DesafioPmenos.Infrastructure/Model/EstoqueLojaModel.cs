using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Model
{
    public class EstoqueLojaModel
    {
        public int IdLoja { get; set; }
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public float PrecoProduto { get; set; }
        public string CidadeLoja { get; set; }
        public string UFLoja { get; set; }
        public string Logradouro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
