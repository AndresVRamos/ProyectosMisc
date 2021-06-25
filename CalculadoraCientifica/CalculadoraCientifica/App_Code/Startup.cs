using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculadoraCientifica.Startup))]
namespace CalculadoraCientifica
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
