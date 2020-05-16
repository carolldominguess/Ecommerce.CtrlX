using Ecommerce.CtrlX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class OrdersConfig : EntityTypeConfiguration<Orders>
    {
        public OrdersConfig()
        {
            HasKey(o => o.OrderId);
            Property(o => o.Date).IsOptional();
            Property(o => o.Remarks).IsOptional();

            ToTable("CtrlX_Orders");
        }
    }
}
