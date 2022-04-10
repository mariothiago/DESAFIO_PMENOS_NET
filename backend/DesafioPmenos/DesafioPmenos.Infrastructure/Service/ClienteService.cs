using DesafioPmenos.Infrastructure.Entity;
using DesafioPmenos.Infrastructure.Model;
using DesafioPmenos.Infrastructure.Repository;
using DesafioPmenos.Infrastructure.Repository.Interfaces;
using DesafioPmenos.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service
{
    public class ClienteService : IClienteService
    {
        private ClienteRepository _repository;
        public ClienteService(IConfiguration config)
        {
            _repository = new ClienteRepository(config);
        }

        public async Task<ClienteModel> GetClientById(int id)
        {
            try
            {
                var entity = await _repository.GetClientById(id);

                var model = new ClienteModel()
                {
                    DataAlteracao = entity.DataAlteracao,
                    IdCliente = entity.IdCliente,
                    Nome = entity.Nome,
                    IdDesconto = entity.IdDesconto,
                    TipoDesconto = entity.TipoDesconto
                };

                return model;
            }
            catch (Exception) { throw; }
        }

        public async Task<int> CreateClient(ClienteModel cliente)
        {
            try
            {
                var entity = new ClienteEntity()
                {
                    DataAlteracao = cliente.DataAlteracao,
                    IdCliente = cliente.IdCliente,
                    Nome = cliente.Nome,
                    IdDesconto = cliente.IdDesconto
                };

                return await _repository.CreateClient(entity);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> UpdateClient(ClienteModel cliente)
        {
            try
            {
                var entity = new ClienteEntity()
                {
                    DataAlteracao = cliente.DataAlteracao,
                    IdCliente = cliente.IdCliente,
                    Nome = cliente.Nome,
                    IdDesconto = cliente.IdDesconto
                };

                return await _repository.UpdateClient(entity);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteClient(int id)
        {
            try
            {
                return await _repository.DeleteClient(id);
            }
            catch (Exception) { throw; }
        }
    }
}
