using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KTGK2.Startup))]
namespace KTGK2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
