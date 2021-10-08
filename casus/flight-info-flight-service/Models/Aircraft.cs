using System;

namespace FlightService.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public String Model { get; set; }
        public int Capacity { get; set; }
        public String Status { get; set; }
        public String FlightNumber { get; set; }
    }
}