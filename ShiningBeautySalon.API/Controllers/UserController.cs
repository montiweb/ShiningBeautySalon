using Microsoft.AspNetCore.Mvc;

using ShiningBeautySalon.API.Interfaces;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[User/[action]]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult GetByID(int ID)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Add(User model)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Delete(User model)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Update(User model)
        {
            throw new System.NotImplementedException();
        }
    }
}
