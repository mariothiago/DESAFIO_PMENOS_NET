using DesafioPmenos.Infrastructure.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        public Task<ProdutoEntity> GetProductByCode(int id);
        public Task<IEnumerable<ProdutoEntity>> GetProductsByStore(int idLoja);
        public Task<int> CreateProduct(ProdutoEntity produto);
        public Task<int> UpdateProduct(ProdutoEntity produto);
        public Task<int> DeleteProduct(int id);
    }
}
