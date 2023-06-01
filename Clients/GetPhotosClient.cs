using autoria_back.Models;
using Newtonsoft.Json;

namespace autoria_back.Clients
{
    public class GetPhotosClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetPhotosClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<PhotosModel> GetPhotosAsync(string auto_id1)
        {
            var response = await _httpClient.GetAsync($"/auto/fotos/{auto_id1}?api_key={_apikey}");
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<PhotosModel>(content);
            return result;
        }
    }
}
