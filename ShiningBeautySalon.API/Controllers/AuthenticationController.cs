using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        //[HttpPost]
        //public ActionResult<User> Login(string username, string password) => _authenticationService.Login(username, password);
    }
}
