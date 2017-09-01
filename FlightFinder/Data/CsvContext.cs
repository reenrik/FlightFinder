using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FlightFinder.Data
{
    public class CsvContext
    {
        readonly string _fileLocation;

        public CsvContext(ApplicationSettings appSettings)
        {
            _fileLocation = appSettings.DataConnectionString;
        }

        public IList<T> Set<T>()
            where T : BaseEntity
        {
            IList<T> entities = new List<T>();
            if (File.Exists(_fileLocation))
            {
                using (var sr = File.OpenText(_fileLocation))
                {
                    CsvReader csvReader = new CsvReader(sr);
                    entities = csvReader.GetRecords<T>().ToList();
                }
            }

            return entities;
        }
    }

    public class AirportsContext : CsvContext
    {
        public AirportsContext(ApplicationSettings appSettings) : base(appSettings)
        {
        }
    }

    public class FlightsContext : CsvContext
    {
        public FlightsContext(ApplicationSettings appSettings) : base(appSettings)
        {
        }
    }
}
