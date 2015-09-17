using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogVDog.Web.Startup))]
namespace DogVDog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
