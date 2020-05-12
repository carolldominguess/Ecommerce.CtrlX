using Ecommerce.CtrlX.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IDepartamentsRepository : IRepository<Departaments>
    {
        Departaments GetDepartamentsById(int id);
        IEnumerable<Departaments> ObterAtivos(int id);
    }
}
