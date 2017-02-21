using HelloWorld.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Server.Services
{
    public class TestService : ITestService
    {
        public Message TestFunction()
        {
            //Set up for future development, read/writing from DB, etc.
            return new Message("Hello World");
        }
    }
}
