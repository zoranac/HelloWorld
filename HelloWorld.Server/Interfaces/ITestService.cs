using HelloWorld.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Server.Services
{
    public interface ITestService
    {
        Message TestFunction();
    }
}
