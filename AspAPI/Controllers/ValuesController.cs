using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("[action]")]
        [HttpGet]
        public string GetName()
        {
            return "Test";
        }

        [Route("[action]")]
        [HttpGet]
        public string GetDescription()
        {
            return "This is a description";
        }
    }
}
