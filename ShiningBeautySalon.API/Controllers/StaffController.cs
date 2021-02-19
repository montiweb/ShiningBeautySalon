using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces; 

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[Staff/[action]]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost]
        public IActionResult Add(Staff model) => Ok(_staffService.Add(model));

        [HttpPost]
        public IActionResult Update(Staff model) => Ok(_staffService.Update(model));

        [HttpPost]
        public IActionResult Delete(Staff model) => Ok(_staffService.Delete(model));

        [HttpGet]
        public IActionResult GetAll() => Ok(_staffService.GetAll());

        [HttpGet]
        public IActionResult GetByID(int staffId) => Ok(_staffService.GetByID(staffId));
    }
}
