using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolView.Startup))]
namespace SchoolView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
