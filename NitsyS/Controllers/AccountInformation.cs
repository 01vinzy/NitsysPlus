using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NitsyS.Controllers
{
    [ApiController]
    [Route("/session")]
    public class AccountInformation : CustomControllerBase<AccountInformation>
    {
        [HttpGet]
        public IActionResult SessionConfig()
        {
            string sessionconfig = System.IO.File.ReadAllText("config.json");
            return Ok(new JsonResult(sessionconfig).Value);
        }
    }
}