using autoria_back.Models;
//using autoria_back.Clients;
using autoria_back.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetMoreAboutController : ControllerBase
    {
        private readonly ILogger<GetAvrPriceController> _logger;

        [HttpPost("chat/brand")]
        public async Task<string> GetMoreAboutAsync([FromBody] Brand brand)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.openai.com/v1/chat/completions"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {Constants.chatgpt_key}");

                    request.Content = new StringContent("{\n    \"model\": \"gpt-3.5-turbo\",\n    \"messages\": [{\"role\": \"user\", \"content\": \"Розкажи мені про авто "+brand.Mark + brand.Model +"і про плюси і мінуси цього авто\"}]\n  }");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    var json = JsonObject.Parse(await response.Content.ReadAsStringAsync());
                    return json["choices"][0]["message"]["content"].ToString();
                }
            }
            
        }
    }
    public class Brand
    {
        public string Mark { get; set; }
        public string Model { get; set; }
    }
}