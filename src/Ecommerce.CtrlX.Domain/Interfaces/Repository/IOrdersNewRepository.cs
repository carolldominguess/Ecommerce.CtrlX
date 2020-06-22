using Ecommerce.CtrlX.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IOrdersNewRepository : IRepository<OrdersNew>
    {
        OrdersNew GetOrderById(int id);
        Task<OrdersNew> GetOrdersByIdAsync(int id);
        IEnumerable<OrdersNew> ObterPedidos();
        IEnumerable<OrdersNew> ObterPedidosByUser(string user);
    }
}
