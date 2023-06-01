using autoria_back.Models;
using autoria_back.Clients;
using Microsoft.AspNetCore.Mvc;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetAdvByIdController : ControllerBase
    {
        private readonly ILogger<GetAdvByIdController> _logger;

        public GetAdvByIdController(ILogger<GetAdvByIdController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "auto_id")]
        public GetAdvByIdModel AdvById(string auto_id)
        {
            GetAdvByIdClient client = new GetAdvByIdClient();
            return client.GetAdvByIdAsync(auto_id).Result;
        }
    }
}
