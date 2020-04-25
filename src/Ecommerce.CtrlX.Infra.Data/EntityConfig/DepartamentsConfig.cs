using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class DepartamentsConfig : EntityTypeConfiguration<Departaments>
    {
        public DepartamentsConfig()
        {
            HasKey(d => d.DepartamentsId);
            Property(d => d.Name).IsOptional().HasMaxLength(100);
            Property(d => d.DataCadastro).IsOptional();
            Property(d => d.DataAlteracao).IsOptional();

            ToTable("CtrlX_Departaments");
        }
    }
}
