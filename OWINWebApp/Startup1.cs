using Microsoft.Owin;

using OWINWebApp;

[assembly: OwinStartup(typeof(Startup1))]

namespace OWINWebApp{

    using Owin;

    public class Startup1{

        public void Configuration(IAppBuilder app){
            app.Run(context =>{
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello Word.");
            });

        }

    }

}