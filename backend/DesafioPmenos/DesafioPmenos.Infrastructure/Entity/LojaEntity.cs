using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Entity
{
    public class LojaEntity
    {
        public int IdLoja { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
    }
}
