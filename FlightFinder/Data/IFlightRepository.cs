using System.Collections.Generic;
using FlightFinder.Models;

namespace FlightFinder.Data
{
    public interface IFlightRepository: IRepository<Flight, string>
    {
        IEnumerable<Flight> GetAll();
        IEnumerable<Flight> Search(string departureCity, string destinationCity);
    }
}
