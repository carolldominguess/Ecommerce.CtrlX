using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;

namespace Ecommerce.CtrlX.Infra.Data.Context
{
    public class CtrlXContext : DbContext
    {
        public CtrlXContext()
            : base("DefaultConnection") { }

        #region EntitiesCtrlX
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Inventories> Inventories { get; set; }
        public DbSet<OrdersNew> OrdersNews { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
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

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            #region EntitiesConfig
            modelBuilder.Configurations.Add(new CategoriesConfig());
            modelBuilder.Configurations.Add(new ProductsConfig());
            modelBuilder.Configurations.Add(new SalesConfig());
            modelBuilder.Configurations.Add(new OrdersNewConfig());
            #endregion


            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {          

            try
            {
                foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
                    }
                    if (entry.State == EntityState.Modified)
                    {
                        entry.Property("RegistrationDate").IsModified = false;
                    }
                }
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
