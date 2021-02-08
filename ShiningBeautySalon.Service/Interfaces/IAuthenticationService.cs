using ShiningBeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface IAuthenticationService
    {
        User Login(string username, string password);
    }
}
