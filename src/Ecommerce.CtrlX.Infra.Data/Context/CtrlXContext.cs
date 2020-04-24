using Ecommerce.CtrlX.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ecommerce.CtrlX.Infra.Data.Context
{
    public class CtrlXContext : DbContext
    {
        public CtrlXContext()
            : base("DefaultConnection") { }

        #region EntitiesCtrlX
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Taxes> Taxes { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                            .Where(p => p.Name == p.ReflectedType.Name + "Id")
                            .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));



            base.OnModelCreating(modelBuilder);
        }
    }
}
