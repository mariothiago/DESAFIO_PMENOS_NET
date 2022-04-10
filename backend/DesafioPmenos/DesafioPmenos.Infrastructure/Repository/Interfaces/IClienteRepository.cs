using DesafioPmenos.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Interfaces
{
    public interface IClienteRepository
    {
        public Task<ClienteEntity> GetClientById(int id);
        public Task<int> CreateClient(ClienteEntity cliente);
        public Task<int> UpdateClient(ClienteEntity cliente);
        public Task<int> DeleteClient(int id);
    }
}
