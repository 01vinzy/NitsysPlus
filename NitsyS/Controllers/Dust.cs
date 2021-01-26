using Microsoft.AspNetCore.Mvc;

namespace NitsyS.Controllers
{
    [ApiController]
    [Route("/dust")]
    public class Dust : ControllerBase
    {
        [HttpPost]
        public IActionResult subscription()
        {

            return Accepted(new JsonResult(new byte[0]).Value);
        }
    }
}
