using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEPREMM.Startup))]
namespace SEPREMM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
