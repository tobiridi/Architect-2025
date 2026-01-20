namespace Labo_Agence_Voyage.ASP_MVC.Services
{
    public class AgenceVoyageApiClient
    {
        private readonly HttpClient _httpClient;

        public AgenceVoyageApiClient(HttpClient httpClient)
        {
            this._httpClient = httpClient;
            this._httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        //TODO: implement API requests
        public async Task TestGetRequest()
        {
            HttpResponseMessage response = await this._httpClient.GetAsync("/test");
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.IsSuccessStatusCode);
        }
    }
}
