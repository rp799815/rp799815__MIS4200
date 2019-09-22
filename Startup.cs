using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rp799815_MIS4200.Startup))]
namespace rp799815_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
