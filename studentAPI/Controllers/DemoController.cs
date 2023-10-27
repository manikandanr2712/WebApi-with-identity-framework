using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace studentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public String Greetings()
        {
            return "Hello";
        }
    }
}
