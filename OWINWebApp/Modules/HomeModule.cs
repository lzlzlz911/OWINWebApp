namespace OWINWebApp.Modules{

    using Nancy;

    public class HomeModule : NancyModule{

        public HomeModule() { Get["/"] = _ => { return View["/Home", new{Name = "saber"}]; }; }

    }

}