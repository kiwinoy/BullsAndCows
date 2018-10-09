using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BullsAndCows.Startup))]
namespace BullsAndCows
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
