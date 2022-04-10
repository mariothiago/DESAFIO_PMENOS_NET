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
    public class EstoqueLojaRepository : IEstoqueLojaRepository
    {
        private IConfiguration _configuration;

        public EstoqueLojaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<IEnumerable<EstoqueLojaEntity>> GetProductsByStore(int idLoja)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryAsync<EstoqueLojaEntity>(EstoqueLojaScripts.GetProductsByStore, new { IdLoja = idLoja });
                }
            }
            catch (Exception) { throw; }
        }
        public async Task<IEnumerable<EstoqueLojaEntity>> GetProductsInStores(int idProduto)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryAsync<EstoqueLojaEntity>(EstoqueLojaScripts.GetProductsInStores, new { IdProduto = idProduto });
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> InsertProductInStore(EstoqueLojaEntity estoque)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(EstoqueLojaScripts.InsertProductInStore, estoque);
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteProductOfStore(int idProduto, int idLoja)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(EstoqueLojaScripts.InsertProductInStore, new { IdProduto = idProduto, IdLoja = idLoja });
                }
            }
            catch (Exception) { throw; }
        }
    }
}
