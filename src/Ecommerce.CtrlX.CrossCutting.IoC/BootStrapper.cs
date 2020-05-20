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
            container.Register<IDepartamentsService, DepartamentsService>(Lifestyle.Scoped);
            container.Register<ICategoriesService, CategorieService>(Lifestyle.Scoped);
            container.Register<IProductsService, ProductsService>(Lifestyle.Scoped);
            container.Register<ISalesService, SalesService>(Lifestyle.Scoped);
            container.Register<ISalesDetailsService, SalesDetailsService>(Lifestyle.Scoped);
            container.Register<IOrdersService, OrdersService>(Lifestyle.Scoped);
            container.Register<IOrdersDetailsService, OrdersDetailsService>(Lifestyle.Scoped);

            //repository
            container.Register<IDepartamentsRepository, DepartamentsRepository>(Lifestyle.Scoped);
            container.Register<ICategoriesRepository, CategoriesRepository>(Lifestyle.Scoped);
            container.Register<IProductsRepository, ProductsRepository>(Lifestyle.Scoped);
            container.Register<ISalesRepository, SalesRepository>(Lifestyle.Scoped);
            container.Register<ISalesDetailsRepository, SalesDetailsRepository>(Lifestyle.Scoped);
            container.Register<IOrdersRepository, OrdersRepository>(Lifestyle.Scoped);
            container.Register<IOrdersDetailsRepository, OrdersDetailsRepository>(Lifestyle.Scoped);

            //infra
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CtrlXContext>(Lifestyle.Scoped);

        }
    }
}
