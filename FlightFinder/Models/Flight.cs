using System;
using FlightFinder.Data;

namespace FlightFinder.Models
{
    public class Flight : BaseEntity
    {
        public string From { get; set; }
        public string To { get; set; }
        public string FlightNumber { get; set; }
        public DateTime Departs { get; set; }
        public DateTime Arrives { get; set; }
        public int MainCabinPrice { get; set; }
        public int FirstClassPrice { get; set; }
    }
}
