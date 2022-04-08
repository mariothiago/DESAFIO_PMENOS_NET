using DesafioPmenos.Infrastructure.Entity;
using DesafioPmenos.Infrastructure.Model;
using DesafioPmenos.Infrastructure.Repository;
using DesafioPmenos.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service
{
    public class ProdutoService : IProdutoService
    {
        private ProdutoRepository _repository;
        public ProdutoService(IConfiguration config)
        {
            _repository = new ProdutoRepository(config);
        }
        public async Task<ProdutoModel> GetProductByCode(int id)
        {
            try
            {
                var entity = await _repository.GetProductByCode(id);
                var model = new ProdutoModel()
                {
                    DataAlteracao = entity.DataAlteracao,
                    DescricaoProduto = entity.DescricaoProduto,
                    IdProduto = entity.IdProduto,
                    PrecoProduto = entity.PrecoProduto
                };

                return model;
            }
            catch(Exception) { throw; }
        }

        public Task<IEnumerable<ProdutoModel>> GetProductsByStore(int idLoja)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateProduct(ProdutoModel produto)
        {
            try
            {
                var model = new ProdutoEntity()
                {
                    DataAlteracao = produto.DataAlteracao,
                    DescricaoProduto = produto.DescricaoProduto,
                    IdProduto = produto.IdProduto,
                    PrecoProduto = produto.PrecoProduto
                };

                return await _repository.CreateProduct(model);
            }
            catch (Exception) { throw; }
            
        }
        public async Task<int> UpdateProduct(ProdutoModel produto)
        {
            try
            {
                var model = new ProdutoEntity()
                {
                    DataAlteracao = produto.DataAlteracao,
                    DescricaoProduto = produto.DescricaoProduto,
                    IdProduto = produto.IdProduto,
                    PrecoProduto = produto.PrecoProduto
                };

                return await _repository.UpdateProduct(model);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteProduct(int id)
        {
            try
            {
                return await _repository.DeleteProduct(id);
            }
            catch (Exception) { throw; }
            
        }
    }
}
