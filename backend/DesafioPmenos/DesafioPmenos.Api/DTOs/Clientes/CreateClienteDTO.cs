using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPmenos.Api.DTOs.Clientes
{
    public class CreateClienteDTO
    {
        public string Nome { get; set; }
        public int IdDesconto { get; set; }

        public ClienteModel GetModel()
        {
            return new ClienteModel()
            {
                DataAlteracao = DateTime.Now,
                Nome = Nome,
                IdDesconto = IdDesconto
            };
        }
    }
}
