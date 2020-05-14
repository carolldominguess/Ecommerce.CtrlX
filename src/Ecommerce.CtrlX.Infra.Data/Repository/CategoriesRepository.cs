using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class CategoriesRepository : Repository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(CtrlXContext context) : base(context)
        {
        }
    }
}
