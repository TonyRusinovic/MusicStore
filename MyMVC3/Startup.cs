using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVC3.Startup))]
namespace MyMVC3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
