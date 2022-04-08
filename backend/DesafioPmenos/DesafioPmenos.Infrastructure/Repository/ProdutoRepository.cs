using Dapper;
using DesafioPmenos.Infrastructure.Entity;
using DesafioPmenos.Infrastructure.Repository.Interfaces;
using DesafioPmenos.Infrastructure.Repository.Scripts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IConfiguration _configuration;

        public ProdutoRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<ProdutoEntity> GetProductByCode(int id)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryFirstAsync<ProdutoEntity>(ProdutoScripts.GetProductById, new { IdProduto = id });
                }
            }
            catch (Exception) { throw; }
            
        }

        public Task<IEnumerable<ProdutoEntity>> GetProductsByStore(int idLoja)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateProduct(ProdutoEntity produto)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ProdutoScripts.CreateProduct, produto);
                }
            }
            catch (Exception) { throw; } 
        }

        public async Task<int> UpdateProduct(ProdutoEntity produto)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ProdutoScripts.UpdateProduct, produto);
                }
            }
            catch (Exception) { throw; } 
        }

        public async Task<int> DeleteProduct(int id)
        {
            try
            {
                using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(ProdutoScripts.DeleteProduct, new { IdProduto = id });
                }
            }
            catch (Exception) { throw; }
        }
    }
}
