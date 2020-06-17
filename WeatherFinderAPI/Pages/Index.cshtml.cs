using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WeatherFinderAPI.Models;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LocationContext _context; //used to get the saved locations
        public IEnumerable<LocationItem> locations { get; private set; } //used to display the saved locations on the home page

        public IndexModel(ILogger<IndexModel> logger, LocationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            locations = _context.LocationItems.ToList();
        }
    }
}
