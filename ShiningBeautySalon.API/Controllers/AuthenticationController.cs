using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.API.Controllers
{

    [Route("Authentication/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authService;
        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public ActionResult<User> Login(string username, string password) => _authService.Login(username, password);
    }
}
