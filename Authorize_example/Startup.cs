using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authorize_example.Startup))]
namespace Authorize_example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
