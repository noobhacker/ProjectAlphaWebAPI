using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectAlphaWebAPI.Models;
using ProjectAlphaWebAPI.Responses;
using Microsoft.EntityFrameworkCore;

namespace ProjectAlphaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        DatabaseContext db;

        public WeatherController(DatabaseContext context)
        {
            db = context;
        }

        [HttpGet("{keyword}")]
        // let swagger display return type instead of IActionResult
        [ProducesResponseType(typeof(List<WeatherResponse>), 200)]
        public async Task<IActionResult> Get(string keyword)
        {
            var query = from weather in db.Weathers
                        where weather.Street.Contains(keyword) ||
                              weather.Park.Contains(keyword) ||
                              weather.City.Contains(keyword) ||
                              weather.Postal.Contains(keyword) ||
                              weather.State.Contains(keyword)
                        select new WeatherResponse()
                        {
                            // the reason i do this is to make conditional tests at database level
                            bestAccuracyLocationName = weather.State.Contains(keyword) ? weather.State :
                                                       // don't response postal! response city name
                                                       weather.Postal.Contains(keyword) ? weather.City :
                                                       weather.City.Contains(keyword) ? weather.City :
                                                       weather.Park.Contains(keyword) ? weather.Park :
                                                       weather.Street.Contains(keyword) ? weather.Street : null,
                            dateTime = weather.DateTime,
                            temperature = weather.Temperature,
                            altitude = weather.Altitude,
                            pressure = weather.Pressure,
                            latitude = weather.Latitude,
                            longitude = weather.Longitude
                        };

            var result = await query.ToListAsync();
            return Ok(result);
        }

        public async Task<IActionResult> Post(Weather weather)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid JSON");

            db.Weathers.Add(weather);
            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
