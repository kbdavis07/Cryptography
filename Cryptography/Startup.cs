using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cryptography.Startup))]
namespace Cryptography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
