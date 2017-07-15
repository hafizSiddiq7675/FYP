using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bp_bms.Startup))]
namespace bp_bms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
