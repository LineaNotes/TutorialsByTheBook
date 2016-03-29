using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5MusicStore.Startup))]
namespace Mvc5MusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
