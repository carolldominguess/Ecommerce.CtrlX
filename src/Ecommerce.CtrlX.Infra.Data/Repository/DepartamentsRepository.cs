using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class DepartamentsRepository : Repository<Departaments>, IDepartamentsRepository
    {
        public DepartamentsRepository(CtrlXContext context) : base(context)
        {
        }

        public Departaments GetDepartamentsById(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}
