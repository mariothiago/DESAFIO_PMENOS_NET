using DesafioPmenos.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Service.Interfaces
{
    public interface IProdutoService
    {
        public Task<ProdutoModel> GetProductByCode(int id);
        public Task<IEnumerable<ProdutoModel>> GetProductsByStore(int idLoja);
        public Task<int> CreateProduct(ProdutoModel produto);
        public Task<int> UpdateProduct(ProdutoModel produto);
        public Task<int> DeleteProduct(int id);
    }
}
