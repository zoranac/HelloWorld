
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorld.Client.Controllers
{
    class Application
    {

        public static string ServerPath
        {
            get { return ConfigurationManager.AppSettings.Get("ServerPath"); }
        }

        public static HttpClient Client = new HttpClient();
        static void Main(string[] args)
       {
            Client.BaseAddress = new Uri("http://localhost:55268/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var MainController = new MainController(new Services.MainService());
            MainController.RunAsync().Wait();

        }
    }
}
