using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface ISalesDetailsService : IDisposable
    {
        SalesDetailsViewModel Add(SalesDetailsViewModel salesDetails);
        SalesDetailsViewModel Update(SalesDetailsViewModel salesDetails);
        SalesDetailsViewModel GetAll(SalesDetailsViewModel salesDetails);
        IEnumerable<SalesDetailsViewModel> GetSalesDetailsById(int id);
    }
}
