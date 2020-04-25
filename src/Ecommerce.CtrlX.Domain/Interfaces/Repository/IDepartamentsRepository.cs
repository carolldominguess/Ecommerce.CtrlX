using Ecommerce.CtrlX.Domain.Entities;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IDepartamentsRepository : IRepository<Departaments>
    {
        Departaments GetDepartamentsById(int id);
    }
}
