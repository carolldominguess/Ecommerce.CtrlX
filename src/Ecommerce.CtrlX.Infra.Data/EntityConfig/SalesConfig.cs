using Ecommerce.CtrlX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class SalesConfig : EntityTypeConfiguration<Sales>
    {
        public SalesConfig()
        {
            HasKey(s => s.SalesId);
            Property(s => s.Date).IsOptional();
            Property(s => s.Remarks).IsOptional();
            Property(s => s.Description).IsOptional();
            Property(s => s.Price).IsOptional();
            Property(s => s.TaxRate).IsOptional();
            Property(s => s.Quantity).IsOptional();

            ToTable("CtrlX_Sales");
        }
    }
}
