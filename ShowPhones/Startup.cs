using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShowPhones.Startup))]
namespace ShowPhones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
