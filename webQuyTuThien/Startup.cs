using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webQuyTuThien.Startup))]
namespace webQuyTuThien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
