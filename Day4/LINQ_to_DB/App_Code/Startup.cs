using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LINQ_to_DB.Startup))]
namespace LINQ_to_DB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
