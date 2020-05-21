using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Ecommerce.CtrlX.Infra.Data.EntityConfig
{
    public class UsersConfig : EntityTypeConfiguration<Users>
    {
        public UsersConfig()
        {
            HasKey(u => u.UsersId);
            Property(u => u.Firstname).HasMaxLength(100).IsOptional();
            Property(u => u.LastName).HasMaxLength(100).IsOptional();
            Property(u => u.Address).HasMaxLength(100).IsOptional();
            Property(u => u.Phone).HasMaxLength(15).IsOptional();
            Property(u => u.Photo).IsOptional();
            Property(u => u.UserName).HasMaxLength(15).IsOptional();

            ToTable("CtrlX_Users");
        }
    }
}