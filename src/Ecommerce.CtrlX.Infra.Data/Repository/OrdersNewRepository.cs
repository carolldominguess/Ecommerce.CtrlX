using Dapper;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class OrdersNewRepository : Repository<OrdersNew>, IOrdersNewRepository
    {
        public OrdersNewRepository(CtrlXContext context) : base(context) { }

        public OrdersNew GetOrderById(int id)
        {
            return SearchFirstOrDefault(x => x.OrdersNewId == id);
        }

        public async Task<OrdersNew> GetOrdersByIdAsync(int id)
        {
            var cn = Db.Database.Connection;
            var sql = "SELECT OrdersNewId, * FROM CtrlX_OrdersNew WHERE OrdersNewId = @id";

            var result = await cn.QueryFirstOrDefaultAsync<OrdersNew>(sql, new { id });
            return result;
        }

        public IEnumerable<OrdersNew> ObterPedidos()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_OrdersNew";
            return cn.Query<OrdersNew>(sql);
        }

        public IEnumerable<OrdersNew> ObterPedidosByUser(string user)
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_OrdersNew Where [User] = @user";
            return cn.Query<OrdersNew>(sql, new { user });
        }
    }
}
