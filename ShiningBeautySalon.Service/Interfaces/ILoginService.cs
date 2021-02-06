using ShiningBeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface ILoginService
    {
        User SignIn(string username, string password);
    }
}
