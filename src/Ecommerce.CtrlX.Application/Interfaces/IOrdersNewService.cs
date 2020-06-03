using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IOrdersNewService : IDisposable
    {
        OrdersNewViewModel Add(OrdersNewViewModel orders);
        OrdersNewViewModel GetOrderById(int id);
        OrdersNewViewModel Update(OrdersNewViewModel orders);
        IEnumerable<OrdersNewViewModel> ObterPedidos();
    }
}
