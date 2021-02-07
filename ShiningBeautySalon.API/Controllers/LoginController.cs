using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiningBeautySalon.API.Controllers
{

    [Route("Login/[action]")]
    [ApiController]
    [AllowAnonymous]
    //[Produces("application/json")]
    //[Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        //[HttpPost("[action]")]
        public ActionResult<User> SignIn(string username, string password) => _loginService.SignIn(username, password);
    }
}
