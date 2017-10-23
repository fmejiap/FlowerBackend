using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerBackend.Startup))]
namespace FlowerBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
