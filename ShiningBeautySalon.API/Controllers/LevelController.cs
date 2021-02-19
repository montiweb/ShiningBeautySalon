using Microsoft.AspNetCore.Mvc;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces; 

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[Level/[action]]")]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;
        public LevelController(ILevelService levelService)
        {
            _levelService = levelService;
        }

        [HttpPost]
        public IActionResult Add(Level model) => Ok(_levelService.Add(model));

        [HttpPost]
        public IActionResult Update(Level model) => Ok(_levelService.Update(model));

        [HttpPost]
        public IActionResult Delete(Level model) => Ok(_levelService.Delete(model));

        [HttpGet]
        public IActionResult GetAll() => Ok(_levelService.GetAll());

        [HttpGet]
        public IActionResult GetByID(int levelId) => Ok(_levelService.GetByID(levelId));
    }
}
