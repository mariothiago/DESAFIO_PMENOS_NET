using DesafioPmenos.Infrastructure.Entity;
using DesafioPmenos.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository
{
    public class LojaRepository : ILojaRepository
    {
        public Task<IEnumerable<LojaEntity>> GetLojaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateLoja(LojaEntity loja)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateLoja(LojaEntity loja)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteLoja(int id)
        {
            throw new NotImplementedException();
        }
    }
}
