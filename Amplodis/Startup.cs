using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amplodis.Startup))]
namespace Amplodis
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
