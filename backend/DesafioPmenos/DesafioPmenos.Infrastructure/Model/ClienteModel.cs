using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Model
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }
        public int IdDesconto { get; set; }
        public string TipoDesconto { get; set; }
        public string Nome { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
