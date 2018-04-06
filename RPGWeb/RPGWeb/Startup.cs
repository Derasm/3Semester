using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPGWeb.Startup))]
namespace RPGWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
