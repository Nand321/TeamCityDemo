using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FortifyTeamCityCICDDemo.Startup))]
namespace FortifyTeamCityCICDDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
