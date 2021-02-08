using ShiningBeautySalon.DAL.Context;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningBeautySalon.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ShiningContext _context;

        public AuthenticationService(ShiningContext ctx)
        {
            _context = ctx;
        }

        List<User> Users = new List<User>() {
        new User(){ ID = 1 ,Password="123456" , Username="Navid" },
        new User(){ ID = 2 ,Password="123456" , Username="Moein" }
        };

        public User Login(string username, string password)
        {
            var user = Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            return user;
        }
    }
}
