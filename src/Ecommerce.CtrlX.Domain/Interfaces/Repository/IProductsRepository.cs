using Ecommerce.CtrlX.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IProductsRepository : IRepository<Products>
    {
        Products GetProductsById(int id);
        IEnumerable<Products> ObterAtivos(int id);
    }
}
