using Dapper;
using DesafioPmenos.Infrastructure.Entity;
using DesafioPmenos.Infrastructure.Repository.Interfaces;
using DesafioPmenos.Infrastructure.Repository.Scripts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private IConfiguration _configuration;

        public ClienteRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<ClienteEntity> GetClientById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryFirstAsync<ClienteEntity>(ClienteScripts.GetById, new { IdCliente = id });
                }
            }
            catch (Exception) { throw; }
        }


        public async Task<int> CreateClient(ClienteEntity cliente)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ClienteScripts.Create, cliente);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> UpdateClient(ClienteEntity cliente)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ClienteScripts.Update, cliente);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteClient(int id)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ClienteScripts.Delete, new { IdCliente = id });
                }
            }
            catch (Exception) { throw; }
        }
    }
}
