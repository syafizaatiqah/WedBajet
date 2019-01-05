using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WedBajet.Startup))]
namespace WedBajet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
