using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.API.MwsBaseController;
using System.Linq;

namespace ShiningBeautySalon.API.Controllers
{
    public class LevelController : MwsControllerBase
    {
        private readonly ILevelService _levelService;
        public LevelController(ILevelService levelService)
        {
            _levelService = levelService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Level>> GetAll()
        {
            string Level_List_Null = "Level list is null";

            try
            {
                IEnumerable<Level> LevelList = _levelService.GetAll();

                return LevelList == null
                    ? StatusCode(StatusCodes.Status404NotFound, Level_List_Null)
                    : StatusCode(StatusCodes.Status200OK, LevelList);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpGet("{ID}")]
        public ActionResult<Level> GetByID(int ID)
        {
            string Level_ID_Not_Valid = "The level Id con not be empty";

            try
            {
                if (!(ID > 0))
                    return StatusCode(StatusCodes.Status400BadRequest, Level_ID_Not_Valid);

                return StatusCode(StatusCodes.Status200OK, _levelService.GetByID(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        public ActionResult<Level> Save(Level model)
        {
            string Level_Entry_Not_Valid = "The level object is not valid";

            try
            {
                if (model == null)
                    return StatusCode(StatusCodes.Status400BadRequest, Level_Entry_Not_Valid);

                return StatusCode(StatusCodes.Status200OK, _levelService.Save(model));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        public ActionResult<Level> Add(Level model)
        {
            return Ok(_levelService.Add(model));
        }

        [HttpPost]
        public ActionResult<Level> Update(Level model)
        {
            return Ok(_levelService.Update(model));
        }

        [HttpPost]
        public ActionResult<Level> Delete(Level model)
        {
            return Ok(_levelService.Delete(model));
        }
    }
}
