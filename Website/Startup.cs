using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AyanMusic.Website.Startup))]
namespace AyanMusic.Website
{
    public partial class Startup
    {
        //  
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
