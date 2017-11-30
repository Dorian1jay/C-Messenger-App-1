using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(messengerapp.Startup))]
namespace messengerapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
