using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParanumusTask1._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {


        [HttpGet("/")]
        public IActionResult Hello()
        {

            return Content("Hello world");
        }
    }
}
