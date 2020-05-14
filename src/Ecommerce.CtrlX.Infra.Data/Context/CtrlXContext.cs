using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ecommerce.CtrlX.Infra.Data.Context
{
    public class CtrlXContext : DbContext
    {
        public CtrlXContext()
            : base("DefaultConnection") { }

        #region EntitiesCtrlX
        public DbSet<Departaments> Departments { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Inventories> Inventories { get; set; }
        public DbSet<Orders> Orders { get; set; }        
        public DbSet<OrdersDetails> OrdersDetails { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }
        public DbSet<Users> Users { get; set; }
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

            #region EntitiesConfig
            modelBuilder.Configurations.Add(new DepartamentsConfig());
            modelBuilder.Configurations.Add(new CategoriesConfig());
            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}
