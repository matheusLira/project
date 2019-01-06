using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InOffice.Startup))]
namespace InOffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
