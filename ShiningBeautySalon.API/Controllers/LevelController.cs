using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System.Collections.Generic;

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;
        public LevelController(ILevelService levelService)
        {
            _levelService = levelService;
        }

        [HttpGet]
        public ActionResult<List<Level>> GetAll() => Ok(_levelService.GetAll());

        [HttpGet("{levelID}")]
        public ActionResult<Level> GetByID(int levelID)
        {

            try
            {
                if (!(levelID > 0))
                    return StatusCode(StatusCodes.Status400BadRequest, "The Level ID can not be empty");

                return StatusCode(StatusCodes.Status200OK, _levelService.GetByID(levelID));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public ActionResult<Level> Add(Level model) => Ok(_levelService.Add(model));

        [HttpPost]
        public ActionResult<Level> Update(Level model) => Ok(_levelService.Update(model));

        [HttpPost]
        public ActionResult<Level> Delete(Level model) => Ok(_levelService.Delete(model));
    }
}
