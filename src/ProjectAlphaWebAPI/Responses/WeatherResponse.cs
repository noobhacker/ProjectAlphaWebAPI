using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlphaWebAPI.Responses
{
    public class WeatherResponse
    {
        public string bestAccuracyLocationName { get; set; }
        public DateTimeOffset dateTime { get; set; }
        public double temperature { get; set; }
    }
}
