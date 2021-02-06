using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalonController : ControllerBase
    {
        private readonly ISalonService salonService;
        public SalonController(ISalonService salonServ)
        {
            salonService = salonServ;
        }

        [HttpGet]
        public ActionResult<IList<Salon>> Get() => salonService.Get().ToList(); 
    }
}
