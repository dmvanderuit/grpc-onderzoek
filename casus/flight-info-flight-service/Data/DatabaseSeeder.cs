using System.Collections.Generic;
using System.Threading.Tasks;
using FlightService.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightService.Data
{
    public static class DatabaseSeeder
    {
        public static async Task SeedDatabase(FlightServiceContext context)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();

            var flightList = new List<Flight>
            {
                new()
                {
                    Id = 1,
                    FlightNumber = "DL74",
                    Airline = "Delta",
                    DepartureTime = "10:15",
                    Origin = "Amsterdam",
                    Destination = "Atlanta",
                    Gate = "22",
                    Terminal = "C"
                },
                new()
                {
                    Id = 2,
                    FlightNumber = "KL1009",
                    Airline = "KLM",
                    DepartureTime = "10:15",
                    Origin = "Amsterdam",
                    Destination = "London",
                    Gate = "07",
                    Terminal = "F"
                },
                new()
                {
                    Id = 3,
                    FlightNumber = "KL835",
                    Airline = "KLM",
                    DepartureTime = "10:30",
                    Origin = "Amsterdam",
                    Destination = "Singapore",
                    Gate = "08",
                    Terminal = "F"
                },
                new()
                {
                    Id = 4,
                    FlightNumber = "SK552",
                    Airline = "SAS",
                    DepartureTime = "10:30",
                    Origin = "Amsterdam",
                    Destination = "Copenhagen",
                    Gate = "02",
                    Terminal = "A"
                },
                new()
                {
                    Id = 5,
                    FlightNumber = "UA908",
                    Airline = "United",
                    DepartureTime = "10:30",
                    Origin = "Amsterdam",
                    Destination = "Chicago",
                    Gate = "06",
                    Terminal = "C"
                },
                new()
                {
                    Id = 6,
                    FlightNumber = "BA431",
                    Airline = "British Airways",
                    DepartureTime = "10:30",
                    Origin = "Amsterdam",
                    Destination = "London",
                    Gate = "01",
                    Terminal = "B"
                },
                new()
                {
                    Id = 7,
                    FlightNumber = "KL713",
                    Airline = "KLM",
                    DepartureTime = "10:45",
                    Origin = "Amsterdam",
                    Destination = "Paramaribo",
                    Gate = "38",
                    Terminal = "F"
                },
                new()
                {
                    Id = 8,
                    FlightNumber = "KL871",
                    Airline = "KLM",
                    DepartureTime = "10:45",
                    Origin = "Amsterdam",
                    Destination = "Delhi",
                    Gate = "21",
                    Terminal = "F"
                },
                new()
                {
                    Id = 9,
                    FlightNumber = "VY8303",
                    Airline = "Vuelling",
                    DepartureTime = "10:50",
                    Origin = "Amsterdam",
                    Destination = "Barcelona",
                    Gate = "34",
                    Terminal = "C"
                },
                new()
                {
                    Id = 10,
                    FlightNumber = "EY78",
                    Airline = "Emirates",
                    DepartureTime = "10:50",
                    Origin = "Amsterdam",
                    Destination = "Abu Dhabi",
                    Gate = "02",
                    Terminal = "E"
                },
                new()
                {
                    Id = 11,
                    FlightNumber = "LH2305",
                    Airline = "Lufthansa",
                    DepartureTime = "10:55",
                    Origin = "Amsterdam",
                    Destination = "Munich",
                    Gate = "43",
                    Terminal = "G"
                },
                new()
                {
                    Id = 12,
                    FlightNumber = "U27939",
                    Airline = "Easy Jet",
                    DepartureTime = "10:55",
                    Origin = "Amsterdam",
                    Destination = "Milan",
                    Gate = "12",
                    Terminal = "B"
                },
                new()
                {
                    Id = 13,
                    FlightNumber = "LX735",
                    Airline = "Swiss",
                    DepartureTime = "11:00",
                    Origin = "Amsterdam",
                    Destination = "Zurich",
                    Gate = "12",
                    Terminal = "C"
                }
            };

            await context.Flights.AddRangeAsync(flightList);
            await context.SaveChangesAsync();
        }
    }
}