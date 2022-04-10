using DesafioPmenos.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Interfaces
{
    public interface IEstoqueLojaRepository
    {
        public Task<IEnumerable<EstoqueLojaEntity>> GetProductsByStore(int idLoja);
        public Task<IEnumerable<EstoqueLojaEntity>> GetProductsInStores(int idProduto);
        public Task<int> InsertProductInStore(EstoqueLojaEntity estoque);
        public Task<int> DeleteProductOfStore(int idProduto, int idLoja);
    }
}
