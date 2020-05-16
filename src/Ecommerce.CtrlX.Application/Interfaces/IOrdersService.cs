using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IOrdersService : IDisposable
    {
        OrdersViewModel Add(OrdersViewModel orders);
        OrdersViewModel GetOrderById(int id);
        OrdersViewModel update(OrdersViewModel orders);
        IEnumerable<OrdersViewModel> ObterPedidos();
    }
}
