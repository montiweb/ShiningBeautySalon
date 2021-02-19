using ShiningBeautySalon.Service.Interfaces; 

namespace ShiningBeautySalon.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationService(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        } 
    }
}
