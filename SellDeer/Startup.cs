using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SellDeer.Startup))]
namespace SellDeer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
