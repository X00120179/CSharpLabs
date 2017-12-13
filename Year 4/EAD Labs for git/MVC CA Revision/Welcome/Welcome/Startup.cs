using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Welcome.Startup))]
namespace Welcome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
