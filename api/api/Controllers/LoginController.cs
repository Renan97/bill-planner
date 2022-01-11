using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/login")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("/signup")]
        public void SignUp(string data)
        {

        }

        [HttpGet]
        [Route("signin")]
        public IActionResult SignIn()
        {
            Result result = Result.GetInstance;
            List<string> list = new List<string>(){
                "Teste 1",
                "Teste 2"
            };

            result = Result.CreateResult(false, "Usuários listados com sucesso!", list);

            return Ok(result);
        }

        [HttpGet]
        [Route("/signin")]
        public ActionResult SignInGet(string username, string password)
        {
            string msg = "Login!";

            return Ok(msg);
        }



        [HttpPost]
        [Route("/forgotpassword")]
        public ActionResult ResetPassword(string username)
        {
            try
            {
                string msg = "Password Updated!";
                return Ok(msg);
            }
            catch (System.Exception error)
            {
                throw error;
            }
        }
    }
}
