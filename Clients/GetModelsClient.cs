using autoria_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using autoria_back.Models;
using System.Net.Http.Json;
using autoria_back.Models;
using Microsoft.VisualBasic;

namespace autoria_back.Clients
{
    public class GetModelsClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetModelsClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<List<Model>> GetModelsAsync(string mark)
        {
            var response = await _httpClient.GetAsync($"/auto/categories/1/marks/{mark}/models?api_key={_apikey}");     // этот метод получает все модели определенной марки легковых авто.
            response.EnsureSuccessStatusCode();                                                               // вместо 1 после marks/ должен быть индекс выбранной пользователем марки
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Model>>(content);
            return result;
        }
    }
}









