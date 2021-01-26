using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Net.Http.Headers;

namespace NitsyS.Controllers
{
    [ApiController]
    [Route("/subscriptions")]
    public class Billing : CustomControllerBase<Profiles>
    {
        [HttpGet]
        public IActionResult subscription()
        {

            string content = System.IO.File.ReadAllText("Exploit.json");
            return Ok(new JsonResult(content).Value);
        }
    }

    [Route("/paywall")]
    public class Pay : CustomControllerBase<Profiles>
    {
        [HttpGet]
        public IActionResult paywall()
        {

            string content = System.IO.File.ReadAllText("paywall.json");
            return Ok(new JsonResult(content).Value);
        }
    }
}