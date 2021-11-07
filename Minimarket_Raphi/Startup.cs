using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Minimarket_Raphi.Startup))]
namespace Minimarket_Raphi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
