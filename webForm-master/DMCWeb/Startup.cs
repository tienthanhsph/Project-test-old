using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMCWeb.Startup))]
namespace DMCWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
