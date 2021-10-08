using System;

namespace FlightService.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public String FlightNumber { get; set; }
        public String Airline { get; set; }
        public String DepartureTime { get; set; }
        public String Origin { get; set; }
        public String Destination { get; set; }
        public String Gate { get; set; }
        public String Terminal { get; set; }
    }
}