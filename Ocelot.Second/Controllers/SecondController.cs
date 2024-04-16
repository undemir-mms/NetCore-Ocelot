using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ocelot.Second.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondController : ControllerBase
    {
        [HttpGet("Get")]
        public string Get()
        {
            return "Second Api Work";
        }
    }
}
