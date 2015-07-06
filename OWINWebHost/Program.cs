namespace OWINWebHost{

    using System;

    using Microsoft.Owin.Hosting;

    using OWINWebApp;

    internal class Program{

        private static void Main(string[] args){
            using (WebApp.Start<Startup1>("http://localhost:9000")){
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }

    }

}
