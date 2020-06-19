using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class ProductsConfig : EntityTypeConfiguration<Products>
    {
        public ProductsConfig()
        {
            HasKey(p => p.ProductsId);
            Property(p => p.Description).IsOptional().HasMaxLength(150);
            Property(p => p.BarCode).IsOptional().HasMaxLength(150);
            Property(p => p.Price).IsOptional().HasMaxLength(20);
            Property(p => p.Image).IsOptional().IsMaxLength();
            Property(p => p.Remarks).IsOptional().HasMaxLength(300);
            Property(p => p.NameCategory).IsOptional().HasMaxLength(100);

            ToTable("CtrlX_Products");
        }
    }
}
