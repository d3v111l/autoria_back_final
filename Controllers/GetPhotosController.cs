using autoria_back.Clients;
using autoria_back.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace autoria_back.Controllers
{

        [ApiController]
        [Route("[controller]")]
        public class GetPhotosController : ControllerBase
        {
            private readonly ILogger<GetPhotosController> _logger;

            public GetPhotosController(ILogger<GetPhotosController> logger)
            {
                _logger = logger;
            }
            [HttpGet(Name = "auto_id1")]
            public PhotosModel AdvById(string auto_id1)
            {
                GetPhotosClient client = new GetPhotosClient();
                return client.GetPhotosAsync(auto_id1).Result;
            }
        }
}
