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
            Property(p => p.BarCode).IsOptional();
            Property(p => p.Price).IsOptional();
            //Property(p => p.Image).IsOptional().HasMaxLength(1000);
            Property(p => p.Remarks).IsOptional().HasMaxLength(150);
            Property(p => p.NameCategory).IsOptional().HasMaxLength(150);

            ToTable("CtrlX_Products");
        }
    }
}
