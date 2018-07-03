using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Workshop3.Startup))]
namespace Workshop3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
