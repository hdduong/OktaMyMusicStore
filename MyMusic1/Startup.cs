using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMusic1.Startup))]
namespace MyMusic1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
