using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IB23_2.Startup))]
namespace IB23_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
