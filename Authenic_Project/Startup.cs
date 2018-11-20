using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authenic_Project.Startup))]
namespace Authenic_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
