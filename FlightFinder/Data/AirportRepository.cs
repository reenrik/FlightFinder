using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using FlightFinder.Models;

namespace FlightFinder.Data
{
    public class AirportRepository: IAirportRepository
    {
        public Airport Get(string airportCode)
        {
            Airport airport = this.GetAll().FirstOrDefault(a => string.Equals(a.Code, airportCode, StringComparison.CurrentCultureIgnoreCase));

            return airport;
        }

        public IEnumerable<Airport> GetAll()
        {
            string filename = @"data/airports.csv";

            IEnumerable<Airport> airports;
            using (StreamReader sr = File.OpenText(filename))
            {
                CsvReader csvReader = new CsvReader(sr);
                airports = csvReader.GetRecords<Airport>().ToList();
            }

            return airports;
        }

        public void Save(Airport entity)
        {
            throw new System.NotSupportedException();
        }

        public void Delete(Airport entity)
        {
            throw new System.NotSupportedException();
        }
    }
}