using Ecommerce.CtrlX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IOrdersRepository : IRepository<Orders>
    {
        Orders GetOrderById(int id);
        IEnumerable<Orders> ObterPedidos();
    }
}
