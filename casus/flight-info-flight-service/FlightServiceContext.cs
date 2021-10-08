using FlightService.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightService
{
    public class FlightServiceContext : DbContext
    {
        public FlightServiceContext(DbContextOptions<FlightServiceContext> options) : base(options)
        {
        }
        
        public DbSet<Flight> Flights { get; set; }
    }
}