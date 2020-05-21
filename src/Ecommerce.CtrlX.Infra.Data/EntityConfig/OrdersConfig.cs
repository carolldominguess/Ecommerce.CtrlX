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
            HasKey(o => o.OrdersId);
            Property(o => o.Date).IsOptional();
            Property(o => o.Remarks).IsOptional();
            Property(o => o.Description).IsOptional();
            Property(o => o.Price).IsOptional();
            Property(o => o.TaxRate).IsOptional();
            Property(o => o.Quantity).IsOptional();

            ToTable("CtrlX_Orders");
        }
    }
}
