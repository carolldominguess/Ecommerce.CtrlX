using Ecommerce.CtrlX.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface ICategoriesRepository : IRepository<Categories>
    {
        Categories GetCategoriesById(int id);
        IEnumerable<Categories> ObterAtivos(int id);
    }
}
