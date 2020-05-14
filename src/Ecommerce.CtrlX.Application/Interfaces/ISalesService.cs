using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface ISalesService : IDisposable
    {
        SalesViewModel Add(SalesViewModel sales);
        SalesViewModel GetSalesById(int id);
        IEnumerable<SalesViewModel> GetAll();
        SalesViewModel Update(SalesViewModel sales);
    }
}
