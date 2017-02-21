using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using HelloWorld.Server.Services;
using System.Net.Http;
using System.Net;
using System.Text;

namespace HelloWorld.Server.Controllers
{
    public class BaseAPIController : ApiController
    {
        private readonly ITestService _testService = new TestService();

        [HttpGet()]
        public async Task<HttpResponseMessage> Get()
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = _testService.TestFunction();
                    
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message.ToString());
                }
            });

        }
    }
}
