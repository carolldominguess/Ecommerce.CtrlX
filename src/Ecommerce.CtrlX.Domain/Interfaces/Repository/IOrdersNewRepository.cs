using Ecommerce.CtrlX.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IOrdersNewRepository : IRepository<OrdersNew>
    {
        OrdersNew GetOrderById(int id);
        IEnumerable<OrdersNew> ObterPedidos();
    }
}
