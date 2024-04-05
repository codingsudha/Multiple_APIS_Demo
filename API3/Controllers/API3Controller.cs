using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API3Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            // Add Delay
            Thread.Sleep(20000);//20 sec

            var result = new
            {
                x = "hello world",
                y = "from app3"
            };
            return Ok(JsonConvert.SerializeObject(result));
        }
    }
}
