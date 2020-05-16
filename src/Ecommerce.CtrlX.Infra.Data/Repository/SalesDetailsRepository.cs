﻿using Dapper;
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
    public class SalesDetailsRepository : Repository<SalesDetails>, ISalesDetailsRepository
    {
        public SalesDetailsRepository(CtrlXContext context) : base(context)
        {
        }

        public SalesDetails GetSalesDetailsById(int id)
        {
            return SearchFirstOrDefault(s => s.SaleDetailId == id);
        }

        public override IEnumerable<SalesDetails> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_SalesDetails";
            return cn.Query<SalesDetails>(sql);
        }
    }
}
