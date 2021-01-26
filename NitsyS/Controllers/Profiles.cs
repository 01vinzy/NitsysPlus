using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Net.Http.Headers;

namespace NitsyS.Controllers
{
    [ApiController]
    [Route("/accounts/me/profiles")]
    public class Profiles : CustomControllerBase<Profiles>
    {
        [HttpGet]
        public IActionResult Profilecontroller()
        {

            string content = System.IO.File.ReadAllText("Profiles.json");
            return Ok(new JsonResult(content).Value);
        }
    }
    [Route("/accounts/me/active-profile")]
    public class SelectedProfile : CustomControllerBase<Profiles>
    {
        [HttpGet]
        public IActionResult ProfileSelect()
        {

            string content = System.IO.File.ReadAllText("SelectedProfile.json");
            return Ok(new JsonResult(content).Value);
        }
    }

    [Route("/accounts/me")]
    public class MainController : CustomControllerBase<Profiles>
    {
        [HttpGet]
        public IActionResult helpmeplz()
        {

            string content = System.IO.File.ReadAllText("Required.json");
            return Ok(new JsonResult(content).Value);
        }
    }
}