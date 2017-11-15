using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_application.Startup))]
namespace First_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
