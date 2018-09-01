using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentAHousband.Startup))]
namespace RentAHousband
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
