using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayFortResponse.Startup))]
namespace PayFortResponse
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
