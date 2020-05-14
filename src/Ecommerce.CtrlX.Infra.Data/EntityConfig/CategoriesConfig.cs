using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class CategoriesConfig : EntityTypeConfiguration<Categories>
    {
        public CategoriesConfig()
        {
            HasKey(c => c.CategoriesId);
            Property(c => c.DescriptionCategory).IsOptional().HasMaxLength(100);
            Property(c => c.DataCadastro).IsOptional();
            Property(c => c.Ativo).IsOptional();

            ToTable("CtrlX_Categories");
        }
    }
}
