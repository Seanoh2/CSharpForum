using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(forumwebsiteCA3.Startup))]
namespace forumwebsiteCA3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
