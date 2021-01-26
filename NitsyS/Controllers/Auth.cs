using Microsoft.AspNetCore.Mvc;

namespace NitsyS.Controllers
{
    [ApiController]
    public class AccountController : CustomControllerBase<AccountController>
    {
        // logging in
        [HttpPost]
        [Route("/idp/login")]
        public IActionResult AccountHandler()
        {
            var response = new
            {
                token_type = "Bearer",
                id_token = "6969420",
                expires_in = 900
            };
            return Ok(new JsonResult(response).Value);
        }
        
        //oauth grant
        [HttpPost]
        [Route("/accounts/grant")]
        public IActionResult Grant()
        {
            var response = new[]
            {
                new
                {
                    grant_type = "urn:ietf:params:oauth:grant-type:jwt-bearer",
                    assertion = "6969420"

                }
            };
            return Ok(new JsonResult(response).Value);
        }

        // Actual Auth Portion
        [HttpPost]
        [Route("/token")]
        public IActionResult Token()
        {
            var response = new[]
            {
                new
                {
                    access_token = "eyJraWQiOiI4ODA0OGI3MS1jMjhlLTQ5MDQtYWMwOS03NzdiMTFmNzUyNDAiLCJhbGciOiJFZERTQSJ9.eyJzdWIiOiIxMzJkYTIwOS1lYmE2LTQyYzktYjU3OC0yYzE1Zjk3N2MzNjIiLCJuYmYiOjE2MTE2ODUwMzEsInBhcnRuZXJOYW1lIjoiZGlzbmV5IiwiaXNzIjoidXJuOmJhbXRlY2g6c2VydmljZTp0b2tlbiIsImNvbnRleHQiOnsiYWN0aXZlX3Byb2ZpbGVfaWQiOiIzYWE5MDg3ZC01ODQ0LTRiNzYtOGYzNC05MDgzYTQxNDJlY2IiLCJ1cGRhdGVkX29uIjoiMjAyMS0wMS0yNlQxODoxNzoxMS43MDArMD",
                    token_type = "bearer",
                    expires_in = 999999,
                    refresh_token = "eyJ6aXAiOiJERUYiLCJraWQiOiJLcTYtNW1Ia3BxOXdzLUtsSUUyaGJHYkRIZFduRjU3UjZHY1h6aFlvZi04IiwiY3R5IjoiSldUIiwiZW5jIjoiQzIwUCIsImFsZyI6ImRpciJ9..gUHPuw9kRyR7YcjN.1f5Ds4LQkNcAXj_zLhNwld9Vm3r-bidxOhzG-R4-_uHPI7g-IO8GrkJlE0_QzzHPr3L0uZRuv68D8qXc2ZpNQ-GWxESqKDJEdVjA433U6llUwnNF8mGMXk_Hu2FB72py6iTiZoBX3kCT5i99VY_dKh1ykxDwVLB3fNAG9mcma2bOk4homgANENf_fj0x0QaluHRcHet-kxFxVNXKNuIfFTwx7pHGf4LlvftEuLz"

                }
            };
            return Ok(new JsonResult(response).Value);
        }
    }
}