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
    public class LojaService : ILojaService
    {
        private LojaRepository _repository;

        public LojaService(IConfiguration config)
        {
            _repository = new LojaRepository(config);
        }

        public async Task<IEnumerable<LojaModel>> GetAllLojas()
        {
            try
            {
                var entity = await _repository.GetAllLojas();
                var modelList = entity.Select(item => new LojaModel()
                {
                    Cidade = item.Cidade,
                    IdLoja = item.IdLoja,
                    Logradouro = item.Logradouro,
                    UF = item.UF
                });

                return modelList;
            }
            catch (Exception) { throw; }
        }

        public async Task<LojaModel> GetLojaById(int id)
        {
            try
            {
                var entity = await _repository.GetLojaById(id);
                var model = new LojaModel()
                {
                    Cidade = entity.Cidade,
                    IdLoja = entity.IdLoja,
                    Logradouro = entity.Logradouro,
                    UF = entity.UF
                };

                return model;
            }
            catch (Exception) { throw; }
        }


        public async Task<int> CreateLoja(LojaModel loja)
        {
            try
            {
                var model = new LojaEntity()
                {
                    Cidade = loja.Cidade,
                    IdLoja = loja.IdLoja,
                    Logradouro = loja.Logradouro,
                    UF = loja.UF
                };

                return await _repository.CreateLoja(model);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> UpdateLoja(LojaModel loja)
        {
            try
            {
                var model = new LojaEntity()
                {
                    Cidade = loja.Cidade,
                    IdLoja = loja.IdLoja,
                    Logradouro = loja.Logradouro,
                    UF = loja.UF
                };

                return await _repository.UpdateLoja(model);

            }
            catch (Exception) { throw; }
        }

        public async Task<int> DeleteLoja(int id)
        {
            try
            {
                return await _repository.DeleteLoja(id);
            }
            catch (Exception) { throw; }
        }
    }
}
