using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dissauer_MIS4800.Startup))]
namespace dissauer_MIS4800
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
