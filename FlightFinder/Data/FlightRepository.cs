using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using FlightFinder.Models;

namespace FlightFinder.Data
{
    public class FlightRepository: IFlightRepository
    {
        public Flight Get(string flightNumber)
        {
            Flight flight = this.GetAll().FirstOrDefault(a => a.FlightNumber == flightNumber);

            return flight;
        }

        public IEnumerable<Flight> GetAll()
        {
            string filename = @"data/flights.csv";

            using (StreamReader sr = File.OpenText(filename))
            {
                CsvReader csvReader = new CsvReader(sr);
                IEnumerable<Flight> flights = csvReader.GetRecords<Flight>().ToList();

                return flights;
            }
        }

        public IEnumerable<Flight> Search(string departureCity, string destinationCity)
        {
            IEnumerable<Flight> flights = this.GetAll().Where(a => string.Equals(a.From, departureCity, StringComparison.CurrentCultureIgnoreCase) && String.Equals(a.To, destinationCity, StringComparison.CurrentCultureIgnoreCase));

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