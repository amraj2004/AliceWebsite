using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AliceWebsite.Startup))]
namespace AliceWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
