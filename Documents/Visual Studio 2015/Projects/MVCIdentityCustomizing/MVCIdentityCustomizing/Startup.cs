using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCIdentityCustomizing.Startup))]
namespace MVCIdentityCustomizing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
