namespace API1.Interfaces
{
    public interface IApi2Service
    {
        public Task<String> Api2Get(HttpClient client);
    }
}
