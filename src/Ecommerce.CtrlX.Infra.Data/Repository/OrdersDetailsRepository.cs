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
    public class OrdersDetailsRepository : Repository<OrdersDetails>, IOrdersDetailsRepository
    {
        public OrdersDetailsRepository(CtrlXContext context) : base(context)
        {
        }

        public OrdersDetails GetOrdersDetailsById(int id)
        {
            return SearchFirstOrDefault(o => o.OrderDetailId == id);
        }

        public override IEnumerable<OrdersDetails> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_OrdersDetails";
            return cn.Query<OrdersDetails>(sql);
        }
    }
}
