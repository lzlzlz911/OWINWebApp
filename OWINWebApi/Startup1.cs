using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(OWINWebApi.Startup1))]

namespace OWINWebApi
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("bugs", "api/{Controller}/{id}", new{id = RouteParameter.Optional});
            app.UseWebApi(config);
        }
    }
}
