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
    public class GetAdvByIdClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetAdvByIdClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<GetAdvByIdModel> GetAdvByIdAsync(string auto_id)
        {
            var response = await _httpClient.GetAsync($"/auto/info?api_key={_apikey}&auto_id={auto_id}");     
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<GetAdvByIdModel>(content);
            return result;
        }
    }
}
