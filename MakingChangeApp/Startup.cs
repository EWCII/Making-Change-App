using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakingChangeApp.Startup))]
namespace MakingChangeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
