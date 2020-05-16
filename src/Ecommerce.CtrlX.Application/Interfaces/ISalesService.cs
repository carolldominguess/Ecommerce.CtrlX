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
        SalesViewModel GetSaleById(int id);
        IEnumerable<SalesViewModel> ObterVendas();
        SalesViewModel Update(SalesViewModel sales);
    }
}
