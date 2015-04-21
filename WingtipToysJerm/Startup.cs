using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingtipToysJerm.Startup))]
namespace WingtipToysJerm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
