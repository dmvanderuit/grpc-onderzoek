#nullable enable
namespace FlightService.Models
{
    public class FlightData
    {
        public string? Terminal { get; set; }
        public string? FlightNumber { get; set; }
        public string? Destination { get; set; }
        public string? DepartureTime { get; set; }
        public string? Gate { get; set; }
        public string? Status { get; set; }
        public string? AircraftModel { get; set; }
    }
}