using Microsoft.AspNetCore.Mvc;
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
        public SalonController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return "Return Data From Context";
        }
    }
}
