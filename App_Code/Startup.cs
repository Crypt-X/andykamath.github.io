using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(andykamath.com.Startup))]
namespace andykamath.com
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
