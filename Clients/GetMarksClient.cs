using autoria_back.Models;
using Newtonsoft.Json;

namespace autoria_back.Clients
{
    public class GetMarksClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetMarksClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<List<Mark>> GetMarksAsync(string category_id1)
        {
            var response = await _httpClient.GetAsync($"/auto/categories/{category_id1}/marks?api_key={_apikey}");     // этот метод получает марки легковых авто
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Mark>>(content);
            return result;
        }
    }
}