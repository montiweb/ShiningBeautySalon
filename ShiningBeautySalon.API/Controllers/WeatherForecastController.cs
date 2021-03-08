using System;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using ShiningBeautySalon.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShiningBeautySalon.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private List<WeatherForecast> result;

        //// 1- IEnumerable
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //// 2- IActionResult by default JSON format
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var rng = new Random();
        //    var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //    return new JsonResult(result);
        //}

        ////  3- IActionResult by Altering the Response Status Code
        // [HttpGet]
        // public IActionResult Get()
        // {
        //     var rng = new Random();
        //     var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();

        //     Response.StatusCode = StatusCodes.Status400BadRequest;

        //     return new JsonResult(result);
        // }


        ////  4- IActionResult by helper methods on the ControllerBase object
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var rng = new Random();
        //    var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //    Response.StatusCode = StatusCodes.Status400BadRequest;

        //    return Ok(result);
        //}

        ////  5- IActionResult by return StatusCode()
        //[HttpGet]
        //public ActionResult Get()
        //{
        //    var rng = new Random();
        //    var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //  //  Response.StatusCode = StatusCodes.Status400BadRequest;

        //    return StatusCode(StatusCodes.Status200OK, result);
        //}

        //// 6- IActionResult by return StatusCode(new JsonResult)
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var rng = new Random();
        //    var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //    Response.StatusCode = StatusCodes.Status400BadRequest;

        //    return StatusCode(StatusCodes.Status500InternalServerError,new JsonResult(result));
        //}


        ////  7- ActionResult by list of a custome defined type and return StatusCode()
        //[HttpGet]
        //public ActionResult<List<WeatherForecast>> Get()
        //{
        //    var rng = new Random();
        //    var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //   .ToList();

        //    return StatusCode(StatusCodes.Status200OK, result);
        //}

        //  8- ActionResult by list of a custome defined type and return StatusCode()
        [HttpGet]
        public async Task<ActionResult<List<WeatherForecast>>> Get()
        {
            //List<WeatherForecast> result = new List<WeatherForecast>();

            await Task.Run(() =>
            {
                var rng = new Random();
                result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
               .ToList();
            });

            return StatusCode(StatusCodes.Status200OK, result);
        }
    }
}
