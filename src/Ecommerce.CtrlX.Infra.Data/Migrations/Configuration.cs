namespace Ecommerce.CtrlX.Infra.Data.Migrations
{
    using Ecommerce.CtrlX.Infra.Data.Context;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CtrlXContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Ecommerce.CtrlX.Infra.Data.Context.CtrlXContext context)
        {

        }
    }
}
