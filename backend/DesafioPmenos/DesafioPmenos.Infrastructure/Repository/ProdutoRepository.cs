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
            using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryFirstAsync<ProdutoEntity>(ProdutoScripts.GetProductById, new { Id = id });
            }
        }

        public Task<IEnumerable<ProdutoEntity>> GetProductsByStore(int idLoja)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateProduct(ProdutoEntity produto)
        {
            using (var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(ProdutoScripts.CreateProduct, produto);
            }
        }

        public Task<int> UpdateProduct(ProdutoEntity produto)
        {
            throw new NotImplementedException();
        }
        public Task<int> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
