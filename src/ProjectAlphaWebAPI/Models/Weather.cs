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

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        public DateTimeOffset DateTime { get; set; }

        [Required]
        [DecimalPrecision(3,6)]
        public double Temperature { get; set; }
        [Required]
        [DecimalPrecision(3, 6)]
        public double Pressure { get; set; }
        [Required]
        [DecimalPrecision(3, 6)]
        public double Altitude { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
