using API1.Interfaces;

namespace API1.Services
{
    public class Api3Service : IApi3Service
    {
        public Task<string> Api3Get(HttpClient client)
        {
            return Extension.CallEndpointAsync(client, "http://localhost:425/api/API3");
        }

    }
}
