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
    public class SalonController : ControllerBase
    {
        private readonly SalonService salonService;
        public SalonController()
        {
            salonService = new SalonService();
        }

        [HttpGet]
        public List<Salon> Get()
        {
            return salonService.Get().ToList();
        }
    }
}
