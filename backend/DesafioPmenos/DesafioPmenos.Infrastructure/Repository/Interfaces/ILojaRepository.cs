using DesafioPmenos.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Interfaces
{
    public interface ILojaRepository
    {
        public Task<IEnumerable<LojaEntity>> GetLojaById(int id);
        public Task<int> CreateLoja(LojaEntity loja);
        public Task<int> UpdateLoja(LojaEntity loja);
        public Task<int> DeleteLoja(int id);
    }
}
