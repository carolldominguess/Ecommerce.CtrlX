using Dapper;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class OrdersRepository : Repository<Orders>, IOrdersRepository
    {
        public OrdersRepository(CtrlXContext context) : base(context)
        {
        }

        public Orders GetOrderById(int id)
        {
            return SearchFirstOrDefault(x => x.OrdersId == id);
        }

        public IEnumerable<Orders> ObterPedidos()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_Orders";
            return cn.Query<Orders>(sql);
        }
    }
}
