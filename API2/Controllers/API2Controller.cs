using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API2.Controllers
{
    [ApiController]
    public class API2Controller : ControllerBase
    {
        [HttpGet]
        [Route("api/Slow")]
        public ActionResult GetSlow()
        {
            // Add Delay
            Thread.Sleep(20000);//20 sec

            var result = new
            {
                x = "hello world",
                y = "from app2"
            };
            return Ok(JsonConvert.SerializeObject(result));
        }
        [HttpGet]
        [Route("api/Get404")]
        public HttpResponse Get404()
        {

            Response.StatusCode = StatusCodes.Status404NotFound;
            return Response;
        }

        [HttpGet]
        [Route("api/Get500")]
        public HttpResponse Get500()
        {
            Response.StatusCode = StatusCodes.Status500InternalServerError;
            return Response;
        }
    }
}
