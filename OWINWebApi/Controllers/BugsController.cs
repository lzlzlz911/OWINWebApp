namespace OWINWebApi.Controllers{

    using System.Web.Http;

    using Newtonsoft.Json;

    public class BugsController : ApiController{

        public string Get(string id) { return JsonConvert.SerializeObject(new{Name = "saber"}); }

    }

}