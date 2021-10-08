using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightService.Data;
using FlightService.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

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
            
            using var channel = GrpcChannel.ForAddress(_configuration.GetValue<String>("GrpcServer"));

            var client = new AircraftService.AircraftServiceClient(channel);
            
            var reply = await client.GetAircraftAsync(new Empty());
            
            var flights = await _context.Flights.ToListAsync();
            
            var allAircraft = reply.AllAircraft;
            
            var flightData = flights.Select(flight =>
            {
                var associatedAircraft =
                    allAircraft.FirstOrDefault(aircraft => aircraft.FlightNumber == flight.FlightNumber);

                return new FlightData
                {
                    Terminal = flight.Terminal,
                    FlightNumber = flight.FlightNumber,
                    Destination = flight.Destination,
                    DepartureTime = flight.DepartureTime,
                    Gate = flight.Gate,
                    Status = associatedAircraft?.Status,
                    AircraftModel = associatedAircraft?.Model
                };
            });
            
            return Ok(flightData);
        }
    }
}