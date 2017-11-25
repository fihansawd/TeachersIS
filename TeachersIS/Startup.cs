using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeachersIS.Startup))]
namespace TeachersIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
