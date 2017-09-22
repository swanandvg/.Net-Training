using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CachingDemo.Startup))]
namespace CachingDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
