using DesafioPmenos.Infrastructure.Entity;
using DesafioPmenos.Infrastructure.Model;
using DesafioPmenos.Infrastructure.Repository;
using DesafioPmenos.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service
{
    public class EstoqueLojaService : IEstoqueLojaService
    {
        private EstoqueLojaRepository _repository;

        public EstoqueLojaService(IConfiguration config)
        {
            _repository = new EstoqueLojaRepository(config);
        }
        public async Task<IEnumerable<EstoqueLojaModel>> GetProductByStore(int idLoja)
        {
            try
            {
                var entity = await _repository.GetProductsByStore(idLoja);

                var model = entity.Select(item => new EstoqueLojaModel()
                {
                    CidadeLoja = item.CidadeLoja,
                    DescricaoProduto = item.DescricaoProduto,
                    IdLoja = item.IdLoja,
                    IdProduto = item.IdProduto,
                    Logradouro = item.Logradouro,
                    PrecoProduto = item.PrecoProduto,
                    UFLoja = item.UFLoja,
                    DataAlteracao = item.DataAlteracao
                });

                return model;
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<EstoqueLojaModel>> GetProductsInStores(int idProduto)
        {
            try
            {
                var entity = await _repository.GetProductsInStores(idProduto);

                var model = entity.Select(item => new EstoqueLojaModel()
                {
                    CidadeLoja = item.CidadeLoja,
                    DescricaoProduto = item.DescricaoProduto,
                    IdLoja = item.IdLoja,
                    IdProduto = item.IdProduto,
                    Logradouro = item.Logradouro,
                    PrecoProduto = item.PrecoProduto,
                    UFLoja = item.UFLoja,
                    DataAlteracao = item.DataAlteracao
                });

                return model;
            }
            catch (Exception) { throw; }
        }

        public async Task<int> InsertProductInStore(EstoqueLojaModel estoque)
        {
            try
            {
                var entity = new EstoqueLojaEntity()
                {
                    IdLoja = estoque.IdLoja,
                    IdProduto = estoque.IdProduto
                };

                return await _repository.InsertProductInStore(entity);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteProductOfStore(int idProduto, int idLoja)
        {
            try
            {
                return await _repository.DeleteProductOfStore(idProduto, idLoja);
            }
            catch (Exception) { throw; }
        }
    }
}
