using System.Collections.Generic;
using System.Linq;
using FlightFinder.Controllers;
using FlightFinder.Data;
using FlightFinder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightFinder.ApiTests
{
    [TestClass]
    public class ApiFlightControllerTests
    {
        //public static class MockRepository
        //{
        //    public static IFlightRepository FlightRepository => new FlightRepository();
        //    public static IAirportRepository AirportRepository => new AirportRepository();
        //}

        //[TestMethod]
        //public void TestGetAirports()
        //{
        //    var flightRespository = MockRepository.FlightRepository;
        //    var airportsRepository = MockRepository.AirportRepository;

        //    // Arrange
        //    var flight = new ApiFlightController(flightRespository, airportsRepository);

        //    // Act
        //    var response = flight.GetAirports();

        //    // Assert
        //    Assert.IsFalse(response.ToList().Count <= 0);
        //}
    }
}
