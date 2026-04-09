using Microsoft.AspNetCore.Mvc;

namespace DevOpsApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from DevOps 🚀";
        }
    }
}