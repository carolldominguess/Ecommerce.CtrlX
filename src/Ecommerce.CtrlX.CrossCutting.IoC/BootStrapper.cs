using Ecommerce.CtrlX.Infra.Data.Context;
using Ecommerce.CtrlX.Infra.Data.UoW;
using SimpleInjector;

namespace Ecommerce.CtrlX.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //service
            //container.Register<IServiceBase, ServiceBase>(Lifestyle.Scoped);

            //repository

            //infra
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CtrlXContext>(Lifestyle.Scoped);

        }
    }
}
