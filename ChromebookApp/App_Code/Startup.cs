using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChromebookApp.Startup))]
namespace ChromebookApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
