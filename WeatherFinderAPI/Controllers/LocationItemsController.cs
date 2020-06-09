using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherFinderAPI.Models;

namespace WeatherFinderAPI.Controllers
{
    // Convention is name of controller [Route("api/LocationItems")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationItemsController : ControllerBase
    {
        private readonly LocationContext _context;

        public LocationItemsController(LocationContext context)
        {
            _context = context;
        }

        // GET: api/LocationItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationItem>>> GetLocationItems()
        {
            return await _context.LocationItems.ToListAsync();
        }

        // GET: api/LocationItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationItem>> GetLocationItem(long id)
        {
            var locationItem = await _context.LocationItems.FindAsync(id);

            if (locationItem == null)
            {
                return NotFound();
            }

            return locationItem;
        }

        // POST: api/LocationItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LocationItem>> PostLocationItem(LocationItem locationItem)
        {
            _context.LocationItems.Add(locationItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLocationItem), new { id = locationItem.Id }, locationItem);
        }

        // DELETE: api/LocationItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationItem>> DeleteLocationItem(long id)
        {
            var locationItem = await _context.LocationItems.FindAsync(id);
            if (locationItem == null)
            {
                return NotFound();
            }

            _context.LocationItems.Remove(locationItem);
            await _context.SaveChangesAsync();

            return locationItem;
        }

        private bool LocationItemExists(long id)
        {
            return _context.LocationItems.Any(e => e.Id == id);
        }
    }
}
