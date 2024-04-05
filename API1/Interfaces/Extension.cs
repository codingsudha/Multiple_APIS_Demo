namespace API1.Interfaces
{
    public static class Extension
    {
        public static async Task<String> CallEndpointAsync(HttpClient client, string url)
        {
            try
            {
                using (var response = await client.GetAsync(url))
                {
                    // Ensure successful response code
                    response.EnsureSuccessStatusCode();

                    return  await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
