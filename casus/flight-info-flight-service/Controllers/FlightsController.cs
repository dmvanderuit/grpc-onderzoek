using System.Linq;
using System.Threading.Tasks;
using FlightService.Data;
using FlightService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FlightService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly FlightServiceContext _context;
        private readonly IConfiguration _configuration;

        public FlightsController(FlightServiceContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<OkObjectResult> Get()
        {
            await DatabaseSeeder.SeedDatabase(_context);
            
            var flights = await _context.Flights.ToListAsync();

            var flightData = flights.Select(flight =>
            {
                return new FlightData
                {
                    Terminal = flight.Terminal,
                    FlightNumber = flight.FlightNumber,
                    Destination = flight.Destination,
                    DepartureTime = flight.DepartureTime,
                    Gate = flight.Gate,
                    Status = null,
                    AircraftModel = null
                };
            });
            
            return Ok(flightData);
        }
    }
}