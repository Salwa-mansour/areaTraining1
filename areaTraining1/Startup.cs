using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(areaTraining1.Startup))]
namespace areaTraining1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
