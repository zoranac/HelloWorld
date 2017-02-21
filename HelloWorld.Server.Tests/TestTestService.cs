using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Server.Models;
using HelloWorld.Server.Controllers;
using System.Threading.Tasks;
using System.Web.Http;
using HelloWorld.Server.Services;

namespace HelloWorld.Server.Tests
{
    [TestClass]
    public class TestTestService
    {
        private TestService _service = new TestService();

        [TestMethod]
        public void GetTestFunction_ShouldReturnMessage()
        {
            var testMessage =  _service.TestFunction();
            Assert.IsNotNull(testMessage);
            Assert.IsTrue(testMessage.MessageText.ToLower() == "hello world");
        }
    }
}
