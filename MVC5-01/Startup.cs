using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_01.Startup))]
namespace MVC5_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
