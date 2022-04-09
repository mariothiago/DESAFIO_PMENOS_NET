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
    public class LojaRepository : ILojaRepository
    {
        private IConfiguration _configuration;

        public LojaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<IEnumerable<LojaEntity>> GetAllLojas()
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryAsync<LojaEntity>(LojaScripts.GetAllLojas);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<LojaEntity> GetLojaById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryFirstAsync<LojaEntity>(LojaScripts.GetLojaById, new { IdLoja = id });
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> CreateLoja(LojaEntity loja)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(LojaScripts.CreateLoja, loja);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> UpdateLoja(LojaEntity loja)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(LojaScripts.UpdateLoja, loja);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteLoja(int id)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(LojaScripts.DeleteLoja, new { Id = id });
                }
            }
            catch (Exception) { throw; }
        }
    }
}
