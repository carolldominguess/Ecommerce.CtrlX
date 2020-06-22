using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IOrdersNewService : IDisposable
    {
        OrdersNewViewModel Add(OrdersNewViewModel orders);
        OrdersNewViewModel GetOrderById(int id);
        Task<OrdersNewViewModel> GetOrdersByIdAsync(int id);
        OrdersNewViewModel Update(OrdersNewViewModel orders);
        IEnumerable<OrdersNewViewModel> ObterPedidos();
        IEnumerable<OrdersNewViewModel> ObterPedidosByUser(string user);
    }
}
