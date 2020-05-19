using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IOrdersDetailsService : IDisposable
    {
        OrdersDetailsViewModel Add(OrdersDetailsViewModel ordersDetails);
        OrdersDetailsViewModel Update(OrdersDetailsViewModel ordersDetails);
        OrdersDetailsViewModel GetAll(OrdersDetailsViewModel ordersDetails);
        IEnumerable<OrdersDetailsViewModel> GetOrdersDetailsById(int id);
    }
}
