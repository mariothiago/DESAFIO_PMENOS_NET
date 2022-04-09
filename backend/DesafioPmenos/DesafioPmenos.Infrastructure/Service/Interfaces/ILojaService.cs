using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service.Interfaces
{
    public interface ILojaService
    {
        public Task<IEnumerable<LojaModel>> GetAllLojas();
        public Task<LojaModel> GetLojaById(int id);
        public Task<int> CreateLoja(LojaModel loja);
        public Task<int> UpdateLoja(LojaModel loja);
        public Task<int> DeleteLoja(int id);
    }
}
