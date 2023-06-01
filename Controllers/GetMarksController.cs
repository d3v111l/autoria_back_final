using autoria_back.Models;
using autoria_back.Clients;
using Microsoft.AspNetCore.Mvc;

namespace autoria_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetMarksController : ControllerBase
    {
        private readonly ILogger<GetMarksController> _logger;

        public GetMarksController(ILogger<GetMarksController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "category_id1")]
        public List<Mark> GetMarks(string category_id1)
        {
            GetMarksClient client = new GetMarksClient();
            return client.GetMarksAsync(category_id1).Result;
        }
    }
}