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
        private ProdutoRepository _produtoRepository;
        public ClienteService(IConfiguration config)
        {
            _repository = new ClienteRepository(config);
            _produtoRepository = new ProdutoRepository(config);
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

        public async Task<string> GetDiscountedPrice(int idCliente, int idProduto)
        {
            try
            {
                var result = "";
                var product = await _produtoRepository.GetProductByCode(idProduto);
                if(product != null)
                {
                    var user = await _repository.GetClientById(idCliente);

                    if(user.IdDesconto == 1) // ouro = 20% de desconto
                    {
                        double valor = product.PrecoProduto;
                        double percentual = 20.0 / 100.0;

                        var discountedPrice = valor - (percentual * valor);

                        result = $"Preço do produto {product.DescricaoProduto} para o usuário {user.Nome} com desconto nível {user.IdDesconto} é {discountedPrice.ToString("C")}";
                    }

                    if (user.IdDesconto == 2) // prata = 15% de desconto
                    {
                        double valor = product.PrecoProduto;
                        double percentual = 15.0 / 100.0;

                        var discountedPrice = valor - (percentual * valor);

                        result = $"Preço do produto {product.DescricaoProduto} para o usuário {user.Nome} com desconto nível {user.IdDesconto} é {discountedPrice.ToString("C")}";
                    }

                    else if (user.IdDesconto == 3) // bronze = 10% de desconto
                    {
                        double valor = product.PrecoProduto;
                        double percentual = 10.0 / 100.0;

                        var discountedPrice = valor - (percentual * valor);

                        result = $"Preço do produto {product.DescricaoProduto} para o usuário {user.Nome} com desconto nível {user.IdDesconto} é {discountedPrice.ToString("C")}";
                    }

                    else if (user.IdDesconto == 4) // diamante = 25% de desconto
                    {
                        double valor = product.PrecoProduto;
                        double percentual = 25.0 / 100.0;

                        var discountedPrice = valor - (percentual * valor);

                        result = $"Preço do produto {product.DescricaoProduto} para o usuário {user.Nome} com desconto nível {user.IdDesconto} é {discountedPrice.ToString("C")}";
                    }

                    else if (user.IdDesconto == 5) // colaborador = 30% de desconto
                    {
                        double valor = product.PrecoProduto;
                        double percentual = 30.0 / 100.0;

                        var discountedPrice = valor - (percentual * valor);

                        result = $"Preço do produto {product.DescricaoProduto} para o usuário {user.Nome} com desconto nível {user.IdDesconto} é {discountedPrice.ToString("C")}";
                    }
                }

                return result;
            }
            catch (Exception) { throw; }
        }
    }
}
