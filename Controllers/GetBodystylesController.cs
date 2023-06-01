using autoria_back.Models;
using autoria_back.Clients;
using autoria_back.Models;
using Microsoft.AspNetCore.Mvc;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetBodystylesController : ControllerBase
    {
        private readonly ILogger<GetBodystylesController> _logger;

        public GetBodystylesController(ILogger<GetBodystylesController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "bodystyle")]
        public List<BodystylesModel> GetBodystyles(string bodystyle)
        {
            GetBodystylesClient client = new GetBodystylesClient();
            return client.GetBodystylesAsync(bodystyle).Result;
        }
    }
}