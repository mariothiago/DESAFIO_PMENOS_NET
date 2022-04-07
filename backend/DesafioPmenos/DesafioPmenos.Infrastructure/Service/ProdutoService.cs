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

        public Task<IEnumerable<ProdutoModel>> GetProductsByStore(int idLoja)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateProduct(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }
        public Task<int> UpdateProduct(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
