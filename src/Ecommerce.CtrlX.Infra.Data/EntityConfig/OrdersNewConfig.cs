using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class OrdersNewConfig : EntityTypeConfiguration<OrdersNew>
    {
        public OrdersNewConfig()
        {
            HasKey(o => o.OrdersNewId);
            Property(o => o.Date).IsOptional();
            Property(o => o.Remarks).IsOptional();
            Property(o => o.Description).IsOptional();
            Property(o => o.Price).IsOptional().HasMaxLength(20);
            Property(o => o.TaxRate).IsOptional();
            Property(o => o.Quantity).IsOptional();
            Property(o => o.ProducstId).IsOptional();

            ToTable("CtrlX_OrdersNew");
        }
    }
}
