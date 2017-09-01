# FlightFinder

This is a .NET Core WebAPI service, but also includes a UI page to execute the search and display the results in a grid.

By default, the project will load up the UI at http://localhost:5444/flight, but I've also enabled Swagger UI at http://localhost:5444/swagger so that you can take a look at the REST api and validate functionality.

Here are some highlights:

# UI Elements
http://localhost:5444/flight - search UI
http://localhost:5444/swagger - Swagger UI

# REST (HTTP GET)
http://localhost:5444/api/flight/airports - list of airports
http://localhost:5444/api/flight - all flights
http://localhost:5444/api/flight/{flightNumber}- flight by id
http://localhost:5444/api/flight/search/{departureCity}/{destinationCity} - search by airport code
http://localhost:5444/api/flight/search/{departureCity}/{destinationCity}?sort=price - search by airport code, sort by MainCabinPrice
http://localhost:5444/api/flight/search/{departureCity}/{destinationCity}?sort=depart - search by airport code, sort by Departs
