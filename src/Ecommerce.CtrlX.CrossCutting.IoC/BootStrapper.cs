using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.Services;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;
using Ecommerce.CtrlX.Infra.Data.Repository;
using Ecommerce.CtrlX.Infra.Data.UoW;
using SimpleInjector;

namespace Ecommerce.CtrlX.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //service
            container.Register<ICategoriesService, CategorieService>(Lifestyle.Scoped);
            container.Register<IProductsService, ProductsService>(Lifestyle.Scoped);
            container.Register<ISalesService, SalesService>(Lifestyle.Scoped);
            container.Register<IOrdersNewService, OrdersNewService>(Lifestyle.Scoped);

            //repository
            container.Register<ICategoriesRepository, CategoriesRepository>(Lifestyle.Scoped);
            container.Register<IProductsRepository, ProductsRepository>(Lifestyle.Scoped);
            container.Register<ISalesRepository, SalesRepository>(Lifestyle.Scoped);
            container.Register<IOrdersNewRepository, OrdersNewRepository>(Lifestyle.Scoped);

            //infra
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CtrlXContext>(Lifestyle.Scoped);

        }
    }
}
