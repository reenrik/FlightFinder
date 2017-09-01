using FlightFinder.Data;

namespace FlightFinder.Models
{
    public class Airport: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
