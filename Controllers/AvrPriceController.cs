using autoria_back.Models;
using autoria_back.Clients;
using autoria_back.Models;
using Microsoft.AspNetCore.Mvc;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetAvrPriceController : ControllerBase
    {
        private readonly ILogger<GetAvrPriceController> _logger;

        public GetAvrPriceController(ILogger<GetAvrPriceController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "marka_id2, model_id")]
        public AvrPriceModel GetAvrPrice(string marka_id2, string model_id)
        {
            GetAvrPriceClient client = new GetAvrPriceClient();
            return client.GetAvrPriceAsync(marka_id2, model_id).Result;
        }
    }
}