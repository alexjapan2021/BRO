using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sample1.Startup))]
namespace sample1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
