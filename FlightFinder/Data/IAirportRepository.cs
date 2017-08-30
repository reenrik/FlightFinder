using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using FlightFinder.Models;

namespace FlightFinder.Data
{
    public interface IAirportRepository: IRepository<Airport, string>
    {
        IEnumerable<Airport> GetAll();
    }
}
