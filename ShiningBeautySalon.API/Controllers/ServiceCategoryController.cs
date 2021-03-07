using Microsoft.AspNetCore.Mvc;

using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces; 

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ServiceCategoryController : ControllerBase
    {
        private readonly IServiceCategoryService _serviceCategoryService;
        public ServiceCategoryController(IServiceCategoryService serviceCategoryService)
        {
            _serviceCategoryService = serviceCategoryService;
        }

        [HttpPost]
        public IActionResult Add(ServiceCategory model) => Ok(_serviceCategoryService.Add(model));

        [HttpPost]
        public IActionResult Update(ServiceCategory model) => Ok(_serviceCategoryService.Update(model));

        [HttpPost]
        public IActionResult Delete(ServiceCategory model) => Ok(_serviceCategoryService.Delete(model));

        [HttpGet]
        public IActionResult GetAll() => Ok(_serviceCategoryService.GetAll());

        [HttpGet]
        public IActionResult GetByID(int serviceCategoryId) => Ok(_serviceCategoryService.GetByID(serviceCategoryId));
    }
}
