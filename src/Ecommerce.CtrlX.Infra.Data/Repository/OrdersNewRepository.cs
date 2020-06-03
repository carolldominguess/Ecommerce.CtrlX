using Dapper;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class OrdersNewRepository : Repository<OrdersNew>, IOrdersNewRepository
    {
        public OrdersNewRepository(CtrlXContext context) : base(context) { }

        public OrdersNew GetOrderById(int id)
        {
            return SearchFirstOrDefault(x => x.OrdersNewId == id);
        }

        public IEnumerable<OrdersNew> ObterPedidos()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_OrdersNew";
            return cn.Query<OrdersNew>(sql);
        }
    }
}
