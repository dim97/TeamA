using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hermes.Startup))]
namespace Hermes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
