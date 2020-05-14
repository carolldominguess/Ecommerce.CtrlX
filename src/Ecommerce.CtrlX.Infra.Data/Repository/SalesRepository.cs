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
    public class SalesRepository : Repository<Sales>, ISalesRepository
    {
        public SalesRepository(CtrlXContext context) : base(context)
        {
        }

        public Sales GetSalesById(int Id)
        {
            return SearchFirstOrDefault(x => x.SaleId == Id);
        }

        public IEnumerable<Sales> ObterVendas(int Id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Sales> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_Sales";
            return cn.Query<Sales>(sql);
        }
    }
}
