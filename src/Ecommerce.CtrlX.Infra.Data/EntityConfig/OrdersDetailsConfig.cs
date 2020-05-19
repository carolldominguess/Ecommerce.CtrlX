using Ecommerce.CtrlX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class OrdersDetailsConfig : EntityTypeConfiguration<OrdersDetails>
    {
        public OrdersDetailsConfig()
        {
            HasKey(o => o.OrderDetailId);
            Property(o => o.Description).IsOptional();
            Property(o => o.Price).IsOptional();
            Property(o => o.Quantity).IsOptional();
            Property(o => o.TaxRate).IsOptional();

            ToTable("CtrlX_OrdersDetails");
        }
    }
}
