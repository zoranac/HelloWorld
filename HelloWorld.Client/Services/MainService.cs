using HelloWorld.Client.Controllers;
using HelloWorld.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Client.Services
{
    class MainService
    {
        public async Task<Message> GetMessageAsync(string path)
        {
            Message message = null;
            HttpResponseMessage response = await Application.Client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                message = await response.Content.ReadAsAsync<Message>();
            }
            return message;
        }
    }
}
