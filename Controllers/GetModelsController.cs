using autoria_back.Models;
using autoria_back.Clients;
using Microsoft.AspNetCore.Mvc;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetModelsController : ControllerBase
    {
        private readonly ILogger<GetModelsController> _logger;

        public GetModelsController(ILogger<GetModelsController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "mark")]
        public List<Model> GetMarks(string mark)
        {
            GetModelsClient client = new GetModelsClient();
            return client.GetModelsAsync(mark).Result;
        }
    }
}