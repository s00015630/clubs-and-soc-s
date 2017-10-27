using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubsProject300.Startup))]
namespace ClubsProject300
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
