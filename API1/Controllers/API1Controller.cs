using API1.Interfaces;
using API1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Newtonsoft.Json;

namespace App1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class API1Controller : ControllerBase
    {
        private readonly IApi2Service _api2;
        private readonly IApi3Service _api3;

        public API1Controller(IApi2Service api2, IApi3Service api3)
        {
            _api2 = api2;
            _api3 = api3;
        }

        [HttpGet]
        [Authorize()]
        public async Task<ActionResult> Get()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Start both calls asynchronously
                    //var task1 = CallEndpointAsync(client, "http://localhost:424/api/Slow");
                    //var task1 = CallEndpointAsync(client, "http://localhost:424/api/Get404");
                    //var task2 = CallEndpointAsync(client, "http://localhost:425/api/API3");

                    var task1 = _api2.Api2Get(client);
                    var task2 = _api3.Api3Get(client);

                    // Wait for both calls to complete
                    await Task.WhenAll(task1, task2);

                    // Process results
                    var result1 = await task1;

                    var result2 = await task2;

                    var r = String.Concat("result1" + result1 + "result2:" + result2);

                    return Ok(JsonConvert.SerializeObject(r));

                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                return Ok(JsonConvert.SerializeObject(e.Message));
            }

        }

        [HttpPost]
        public IActionResult Post(string input)
        {
            return Ok(JsonConvert.SerializeObject(input));
        }
    }
}
