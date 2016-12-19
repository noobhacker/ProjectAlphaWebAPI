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
        public double pressure { get; set; }
        public double altitude { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }
    }
}
