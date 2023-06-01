using autoria_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using System.Net.Http.Json;
using Microsoft.VisualBasic;

namespace autoria_back.Clients
{
    public class GetAvrPriceClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetAvrPriceClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<AvrPriceModel> GetAvrPriceAsync(string marka_id2, string model_id)
        {
            var response = await _httpClient.GetAsync($"/auto/average_price?api_key={_apikey}&marka_id={marka_id2}&model_id={model_id}");     // этот метод получает среднюю цену по запросу с параметрами
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<AvrPriceModel>(content);
            return result;
        }
    }
}
