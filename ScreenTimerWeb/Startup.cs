using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScreenTimerWeb.Startup))]
namespace ScreenTimerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
