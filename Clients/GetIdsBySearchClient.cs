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
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace autoria_back.Clients
{
    public class GetIdsBySearchClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        private static string _user_id;

        public GetIdsBySearchClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _user_id = Constants.user_id;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<string> GetIdsBySearchAsync(string marka_id, string model_id, string price_ot, string price_do, string year_ot, string year_do)
        {
            var response = await _httpClient.GetAsync($"/auto/search?api_key={_apikey}&category_id=1&marka_id={marka_id}&model_id={model_id}&with_photo=1&price_ot={price_ot}&price_do={price_do}&s_yers={year_ot}&po_yers={year_do}");
            var content = response.Content.ReadAsStringAsync();
            var result = content.Result;

            JObject json = JObject.Parse(result);
            JArray idsArray = (JArray)json["result"]["search_result"]["ids"];
            Search_result search_Result = new Search_result();
            var ids = new List<string>();
            foreach (string i in idsArray)
                ids.Add(i);
            search_Result.Ids = ids;
            search_Result.Count = Convert.ToInt32(json["result"]["search_result"]["count"].ToString());
            search_Result.LastId = Convert.ToInt32(json["result"]["search_result"]["last_id"].ToString());
            Result res = new Result();
            res.search_Result = search_Result;
            var resres = System.Text.Json.JsonSerializer.Serialize(res);
            return resres;
        }
    }
}