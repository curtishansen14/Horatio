using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Horatio.Startup))]
namespace Horatio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
