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
        public async Task<List<WeatherResponse>> Get(string keyword)
            => await (from weather in db.Weathers
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
                          temperature = weather.Temperature
                      }).ToListAsync();
    }
}
