using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnderecosWeb.Startup))]
namespace EnderecosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
