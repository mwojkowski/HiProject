using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HolyInnocents.Startup))]
namespace HolyInnocents
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
