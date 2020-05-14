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
            HasKey(s => s.SaleId);
            Property(s => s.Date).IsOptional();
            Property(s => s.Remarks).IsOptional();

            ToTable("CtrlX_Sales");
        }
    }
}
