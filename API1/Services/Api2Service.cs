using API1.Interfaces;

namespace API1.Services
{
    public class Api2Service : IApi2Service
    {
        public Task<string> Api2Get(HttpClient client)
        {

            return Extension.CallEndpointAsync(client, "http://localhost:424/api/Slow");
            //var task1 =  Extension.CallEndpointAsync(client, "http://localhost:424/api/Get404");
        }

    }
}
