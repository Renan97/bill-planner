using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoginController
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("/signup")]
        public void SignUp(string data)
        {

        }

        [HttpPost]
        [Route("/signin")]
        public ActionResult SignIn(string username, string password)
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