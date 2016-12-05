using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectAlphaWebAPI.Models;

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


    }
}
