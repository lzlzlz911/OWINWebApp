namespace OWINWebApi.Controllers{

    using System;
    using System.Web.Http;

    using Newtonsoft.Json;

    public class BugsController : ApiController{

        public string GetResult(){
            return JsonConvert.SerializeObject(new ResponseDTO{UName = "saber", UPassword = "twinkle"});
        }

    }

    [Serializable]
    public class ResponseDTO{

        public string UName { set; get; }
        public string UPassword { set; get; }

    }

}