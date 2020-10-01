using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Payfort_Testing.Startup))]
namespace Payfort_Testing
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
