using System;
using System.Collections.Generic;
using System.Linq;
using FlightFinder.Models;

namespace FlightFinder.Data
{
    public class FlightRepository: IFlightRepository
    {
        private readonly FlightsContext _flightsContext;
        IEnumerable<Flight> _flights;

        public FlightRepository(FlightsContext context)
        {
            _flightsContext = context;
        }

        protected IEnumerable<Flight> Flights => _flights ?? (_flights = _flightsContext.Set<Flight>());

        public Flight Get(string flightNumber)
        {
            Flight flight = Flights.FirstOrDefault(a => a.FlightNumber == flightNumber);

            return flight;
        }

        public IEnumerable<Flight> GetAll()
        {
            return Flights;
        }

        public IEnumerable<Flight> Search(string departureCity, string destinationCity)
        {
            IEnumerable<Flight> flights = Flights.Where(a => string.Equals(a.From, departureCity, StringComparison.CurrentCultureIgnoreCase) && String.Equals(a.To, destinationCity, StringComparison.CurrentCultureIgnoreCase));

            return flights;
        }

        public void Save(Flight entity)
        {
            throw new NotSupportedException();
        }

        public void Delete(Flight entity)
        {
            throw new NotSupportedException();
        }
    }
}