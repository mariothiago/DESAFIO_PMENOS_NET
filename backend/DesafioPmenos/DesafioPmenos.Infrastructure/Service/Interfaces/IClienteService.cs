using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service.Interfaces
{
    public interface IClienteService
    {
        public Task<ClienteModel> GetClientById(int id);
        public Task<string> GetDiscountedPrice(int idCliente, int idProduto);
        public Task<int> CreateClient(ClienteModel cliente);
        public Task<int> UpdateClient(ClienteModel cliente);
        public Task<int> DeleteClient(int id);
    }
}
