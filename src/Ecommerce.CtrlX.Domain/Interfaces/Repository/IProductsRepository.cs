using Ecommerce.CtrlX.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IProductsRepository : IRepository<Products>
    {
        Products GetProductsById(int id);
        Task<Products> GetProdutosByIdAsync(int id);
        IEnumerable<Products> ObterAtivos(int id);
    }
}
