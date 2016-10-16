using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOC.Sample.Web.Startup))]
namespace IOC.Sample.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
