using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ecommerce.CtrlX.UI.Site.Startup))]
namespace Ecommerce.CtrlX.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
