using System;
using System.Collections.Generic;
using System.Linq;
using FlightFinder.Models;

namespace FlightFinder.Data
{
    public class AirportRepository: IAirportRepository
    {
        private readonly AirportsContext _airportsContext;
        IEnumerable<Airport> _airports;

        public AirportRepository(AirportsContext context)
        {
            _airportsContext = context;
        }

        protected IEnumerable<Airport> Airports => _airports ?? (_airports = _airportsContext.Set<Airport>());

        public Airport Get(string airportCode)
        {
            return Airports.FirstOrDefault(a => string.Equals(a.Code, airportCode, StringComparison.CurrentCultureIgnoreCase));
        }

        public IEnumerable<Airport> GetAll()
        {
            return Airports;
        }

        public void Save(Airport entity)
        {
            throw new NotSupportedException();
        }

        public void Delete(Airport entity)
        {
            throw new NotSupportedException();
        }
    }
}