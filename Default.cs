using Microsoft.AspNetCore.Mvc;

namespace NitsyS
{
    [ApiController]
    [Route("/")]
    public class Default : ControllerBase
    {
        [HttpGet]
        [HttpPost]
        public IActionResult Greeting() => Ok("Server is running . . .");
    }
}