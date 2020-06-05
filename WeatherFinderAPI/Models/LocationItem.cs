using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherFinderAPI.Models
{
    public class LocationItem
    {
        public long Id { get; set; } // key in database
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
