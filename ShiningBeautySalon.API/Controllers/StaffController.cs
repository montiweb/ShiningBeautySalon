using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly StaffService staffService;
        public StaffController()
        {
            staffService = new StaffService();
        }
       
        [HttpGet]
        public ActionResult<IList<Salon>> Get()
        {
            return staffService.GetAll().ToArray();
        }
    }
}
