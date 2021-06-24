using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Armada.Startup))]
namespace Armada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
