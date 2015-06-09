using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_Code_first.Startup))]
namespace EF_Code_first
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
