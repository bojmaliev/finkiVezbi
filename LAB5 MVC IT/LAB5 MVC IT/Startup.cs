using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB5_MVC_IT.Startup))]
namespace LAB5_MVC_IT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
