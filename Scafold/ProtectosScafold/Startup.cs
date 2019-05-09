using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProtectosScafold.Startup))]
namespace ProtectosScafold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
