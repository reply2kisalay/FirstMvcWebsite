using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMbcWebsite.Startup))]
namespace FirstMbcWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
