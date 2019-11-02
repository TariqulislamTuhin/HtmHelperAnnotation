using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmHelperAnnotation.Startup))]
namespace HtmHelperAnnotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
