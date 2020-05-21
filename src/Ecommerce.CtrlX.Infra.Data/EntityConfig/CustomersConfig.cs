using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class CustomersConfig : EntityTypeConfiguration<Customers>
    {
        public CustomersConfig()
        {
            HasKey(c => c.CustomersId);
            Property(c => c.FirstName).HasMaxLength(100).IsOptional();
            Property(c => c.LastName).HasMaxLength(100).IsOptional();
            Property(c => c.Address).HasMaxLength(200).IsOptional();
            Property(c => c.Phone).HasMaxLength(15).IsOptional();

            ToTable("CtrlX_Customers");
        }
    }
}
