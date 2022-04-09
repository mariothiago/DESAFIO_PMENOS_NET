using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPmenos.Api.DTOs.Lojas
{
    public class CreateLojaDTO
    {
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Logradouro { get; set; }

        public LojaModel GetModel()
        {
            return new LojaModel()
            {
                Cidade = Cidade,
                Logradouro = Logradouro,
                UF = UF
            };
        }
    }
}
