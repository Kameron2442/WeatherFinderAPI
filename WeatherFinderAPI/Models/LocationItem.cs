using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WeatherFinderAPI.Models
{
    public class LocationItem
    {
        [Key]
        public long Id { get; set; } // key in database
        public string LocName { get; set; } // name of location
        public double Lat { get; set; } // latitude
        public double Lon { get; set; } // longitude

    }

}
