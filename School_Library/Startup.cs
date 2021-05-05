using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School_Library.Startup))]
namespace School_Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
