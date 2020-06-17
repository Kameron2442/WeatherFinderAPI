using System.ComponentModel.DataAnnotations;

namespace WeatherFinderAPI.Models
{
    public class LocationItem
    {
        [Key]
        public int Id { get; set; } // key in database
        public string LocName { get; set; } // name of location
        public float Lat { get; set; } // latitude
        public float Lon { get; set; } // longitude

    }

}
