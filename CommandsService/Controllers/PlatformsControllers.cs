using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        [HttpPost]
        public ActionResult TestInboudConnection(){
            Console.WriteLine("--> Inboud Post # command service");

            return Ok("Inbound test of from Platforms controller");
        }
    }
}