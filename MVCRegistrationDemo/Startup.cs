using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRegistrationDemo.Startup))]
namespace MVCRegistrationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
