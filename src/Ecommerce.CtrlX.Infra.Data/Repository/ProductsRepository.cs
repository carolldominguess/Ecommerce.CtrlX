using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class ProductsRepository : Repository<Products>, IProductsRepository
    {
        public ProductsRepository(CtrlXContext context) : base(context)
        {
        }
    }
}
