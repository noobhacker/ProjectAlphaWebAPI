using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlphaWebAPI.Responses
{
    public class WeatherResponse
    {
        public string street { get; set; }
        public string park { get; set; }
        public string postal { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public DateTimeOffset dateTime { get; set; }
        public double temperature { get; set; }
    }
}
