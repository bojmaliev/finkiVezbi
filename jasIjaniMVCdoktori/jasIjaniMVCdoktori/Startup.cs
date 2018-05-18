using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jasIjaniMVCdoktori.Startup))]
namespace jasIjaniMVCdoktori
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
