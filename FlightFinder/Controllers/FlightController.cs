using System.Collections.Generic;
using System.Linq;
using FlightFinder.Data;
using FlightFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightFinder.Controllers
{
    [Produces("application/json")]
    [Route("api/flight")]
    public class FlightController : Controller
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IAirportRepository _airportRepository;

        public FlightController(IFlightRepository flightRepository, IAirportRepository airportRepository)
        {
            _flightRepository = flightRepository;
            _airportRepository = airportRepository;
        }

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _flightRepository.GetAll();
        }

        [HttpGet("{flightNumber}")]
        public Flight Get(string flightNumber)
        {
            return _flightRepository.Get(flightNumber);
        }

        [HttpGet("search/{departureCity}/{destinationCity}")]
        public IEnumerable<Flight> Get(string departureCity, string destinationCity, string sort = null)
        {
            IEnumerable<Flight> flights = _flightRepository.Search(departureCity, destinationCity);

            switch (sort)
            {
                case "price":
                    return flights.OrderBy(f => f.MainCabinPrice);
                case "depart":
                    return flights.OrderBy(f => f.Departs);
                default:
                    return flights;
            }
        }

        [HttpGet("airports")]
        public IEnumerable<Airport> GetAirports()
        {
            return _airportRepository.GetAll();
        }
    }
}
