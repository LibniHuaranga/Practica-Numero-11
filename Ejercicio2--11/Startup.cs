using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejercicio2__11.Startup))]
namespace Ejercicio2__11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
