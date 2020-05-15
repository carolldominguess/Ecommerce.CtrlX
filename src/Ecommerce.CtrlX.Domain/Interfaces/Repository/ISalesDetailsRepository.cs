using Ecommerce.CtrlX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface ISalesDetailsRepository : IRepository<SalesDetails>
    {
        SalesDetails GetSalesDetailsById(int Id);
    }
}
