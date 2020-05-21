using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class InventoriesConfig : EntityTypeConfiguration<Inventories>
    {
        public InventoriesConfig()
        {
            HasKey(i => i.InventoriesId);
            Property(i => i.Stock).IsOptional();
            //Property(i => i.ProductsId).IsOptional();

            ToTable("CtrlX_Inventories");
        }
    }
}
