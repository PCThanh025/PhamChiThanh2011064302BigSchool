using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamChiThanh2011064302.Startup))]
namespace PhamChiThanh2011064302
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
