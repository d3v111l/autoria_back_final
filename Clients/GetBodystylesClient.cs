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
    public class GetBodystylesClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetBodystylesClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<List<BodystylesModel>> GetBodystylesAsync(string bodystyle)
        {
            var response = await _httpClient.GetAsync($"/auto/categories/{bodystyle}/bodystyles?api_key={_apikey}");     // этот метод получает все типы кузовов легковых авто
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<BodystylesModel>>(content);
            return result;
        }
    }
}
