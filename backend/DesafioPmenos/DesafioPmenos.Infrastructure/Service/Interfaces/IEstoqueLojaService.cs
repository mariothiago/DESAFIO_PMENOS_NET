using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service.Interfaces
{
    public interface IEstoqueLojaService
    {
        public Task<IEnumerable<EstoqueLojaModel>> GetProductByStore(int idLoja);
        public Task<IEnumerable<EstoqueLojaModel>> GetProductsInStores(int idProduto);
        public Task<int> InsertProductInStore(EstoqueLojaModel estoque);
        public Task<int> DeleteProductOfStore(int idProduto, int idLoja);
    }
}
