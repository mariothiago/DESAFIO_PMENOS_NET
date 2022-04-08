using DesafioPmenos.Infrastructure.Model;
using DesafioPmenos.Infrastructure.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service
{
    public class LojaService : ILojaService
    {
        public Task<IEnumerable<LojaModel>> GetLojaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateLoja(LojaModel loja)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateLoja(LojaModel loja)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteLoja(int id)
        {
            throw new NotImplementedException();
        }
    }
}
