using Microsoft.Owin;
using OWINNancy;
using Owin;

[assembly: OwinStartup(typeof (Startup1))]
namespace OWINNancy{

    public class Startup1{

        public void Configuration(IAppBuilder app) { app.UseNancy(); }

    }

}