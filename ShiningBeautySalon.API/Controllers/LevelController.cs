using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.API.MwsBaseController;

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

        [ActionName("Save")]
        [HttpPost]
        public ActionResult<Level> Save([FromBody]Level Entity)
        {
            string Level_Entry_Not_Valid = "The level object is not valid";

            try
            {
                if (Entity == null)
                    return StatusCode(StatusCodes.Status400BadRequest, Level_Entry_Not_Valid);

                return StatusCode(StatusCodes.Status200OK, _levelService.Save(Entity));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [ActionName("SaveAsync")]
        [HttpPost]
        public ActionResult<Level> SaveAsync([FromBody] Level Entity)
        {
            string Level_Entry_Not_Valid = "The level object is not valid";

            try
            {
                if (Entity == null)
                    return StatusCode(StatusCodes.Status400BadRequest, Level_Entry_Not_Valid);

                return _levelService.SaveAsync(Entity).Result > 0
                    ? StatusCode(StatusCodes.Status200OK, Entity)
                    : StatusCode(StatusCodes.Status404NotFound, "Not Saved");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        public ActionResult<Level> Delete(Level Entity)
        {
            string Level_Entry_Not_Valid = "The level object is not valid";

            try
            {
                if (Entity == null)
                    return StatusCode(StatusCodes.Status400BadRequest, Level_Entry_Not_Valid);

                return StatusCode(StatusCodes.Status200OK, _levelService.Delete(Entity));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
