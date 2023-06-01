using autoria_back.Models;
using autoria_back.Clients;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetIdsBySearchController : ControllerBase
    {
        private readonly ILogger<GetIdsBySearchController> _logger;

        public GetIdsBySearchController(ILogger<GetIdsBySearchController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "marka_id, model_id, price_ot, price_do")]
        public Result GetIdsBySearch(string marka_id, string model_id, string price_ot, string price_do, string year_ot, string year_do)
        {
            GetIdsBySearchClient client = new GetIdsBySearchClient();
            var str = client.GetIdsBySearchAsync(marka_id, model_id, price_ot, price_do, year_ot, year_do).Result;
            var res = JsonSerializer.Deserialize<Result>(str);
            return res;
        }
    }
}