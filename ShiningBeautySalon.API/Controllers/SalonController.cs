using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces; 

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[Salon/[action]]")]
    public class SalonController : ControllerBase
    {
        private readonly ISalonService _salonService;
        public SalonController(ISalonService salonService)
        {
            _salonService = salonService;
        }

        [HttpPost]
        public IActionResult Add(Salon model) => Ok(_salonService.Add(model));

        [HttpPost]
        public IActionResult Update(Salon model) => Ok(_salonService.Update(model));

        [HttpPost]
        public IActionResult Delete(Salon model) => Ok(_salonService.Delete(model));

        [HttpGet]
        public IActionResult GetAll() => Ok(_salonService.GetAll());

        [HttpGet]
        public IActionResult GetByID(int salonId) => Ok(_salonService.GetByID(salonId));

    }
}
