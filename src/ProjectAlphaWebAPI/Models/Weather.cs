using ProjectAlphaWebAPI.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlphaWebAPI.Models
{
    public class Weather
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Park { get; set; }

        [StringLength(6)]
        public string Postal { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        public DateTimeOffset DateTime { get; set; }

        [DecimalPrecision(3,6)]
        public double Temperature { get; set; }
    }
}
