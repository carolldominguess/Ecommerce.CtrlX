using Ecommerce.CtrlX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class SalesDetailsConfig : EntityTypeConfiguration<SalesDetails>
    {
        public SalesDetailsConfig()
        {
            HasKey(s => s.SaleDetailId);
            Property(s => s.Description).IsOptional();
            Property(s => s.Price).IsOptional();
            Property(s => s.Quantity).IsOptional();
            Property(s => s.TaxRate).IsOptional();

            ToTable("CtrlX_SalesDetails");
        }
    }
}
