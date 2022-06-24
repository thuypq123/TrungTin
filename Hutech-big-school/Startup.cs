using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hutech_big_school.Startup))]
namespace Hutech_big_school
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
