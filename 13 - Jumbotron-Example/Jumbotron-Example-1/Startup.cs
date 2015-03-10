using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jumbotron_Example_1.Startup))]
namespace Jumbotron_Example_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
