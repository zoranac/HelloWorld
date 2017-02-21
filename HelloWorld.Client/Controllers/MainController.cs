using HelloWorld.Client.Models;
using HelloWorld.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld.Client.Controllers
{
    class MainController
    {
        MainService _mainService;
        public MainController(MainService mainService)
        {
            _mainService = mainService;
        }

        public async Task RunAsync()
        {
            var message = await _mainService.GetMessageAsync(Application.ServerPath + "message");
            Console.WriteLine(message.MessageText);

            Console.ReadLine();
        }
     
    }
}
