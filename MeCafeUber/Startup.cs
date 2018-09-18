using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeCafeUber.Startup))]
namespace MeCafeUber
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
