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

            //repository
            container.Register<IDepartamentsRepository, DepartamentsRepository>(Lifestyle.Scoped);

            //infra
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CtrlXContext>(Lifestyle.Scoped);

        }
    }
}
