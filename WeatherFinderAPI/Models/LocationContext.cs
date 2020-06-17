using Microsoft.EntityFrameworkCore;


namespace WeatherFinderAPI.Models
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {
        }

        public DbSet<LocationItem> LocationItems { get; set; }
    }
}
