using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyResumeWebsite.Startup))]
namespace MyResumeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
