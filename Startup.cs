using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(showRDLC.Startup))]
namespace showRDLC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
