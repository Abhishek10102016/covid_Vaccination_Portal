using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MindRuby.Cowin.PresentationL.Startup))]
namespace MindRuby.Cowin.PresentationL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
