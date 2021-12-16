# Amadeus Dotnet SDK

[![Contact Support](https://github.com/amadeus4dev/amadeus-dotnet/raw/master/.github/images/support.svg?sanitize=true)][support]
![GitHub issues](https://img.shields.io/github/issues/amadeus4dev/amadeus-dotnet)
![GitHub](https://img.shields.io/github/license/amadeus4dev/amadeus-dotnet)
![Nuget](https://img.shields.io/nuget/v/amadeus-dotnet)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/amadeus4dev/amadeus-dotnet)

Amadeus provides a set of APIs for the travel industry. Flights, Hotels, Locations and more.

For more details see the [C#
documentation](https://amadeus4dev.github.io/amadeus-dotnet/) on
[Amadeus.com](https://developers.amadeus.com).

## Installation

You can install the SDK via NuGet packages installer, simple search for Amadeus SDK in package explorer.


## Getting Started

To send make your first API call you will need to [register for an Amadeus
Developer Account](https://developers.amadeus.com/create-account) and set up
your first application.

```C#
using System;
using System.IO;
using System.Net;
using System.Text;

using amadeus;
using amadeus.util;

namespace amadeustest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetLocations();
        }

        public static void GetLocations()
        {
            try
            {

                var apikey = "REPLACE_BY_YOUR_API_KEY";
                var apisecret = "REPLACE_BY_YOUR_API_SECRET";

                Configuration amadeusconfig = Amadeus.builder(apikey, apisecret);
                amadeusconfig.setLoglevel("debug");
                Amadeus amadeus = amadeusconfig.build();

                Console.WriteLine("Get CheckinLink:");
                amadeus.resources.CheckinLink[] checkinLinks = amadeus.referenceData.urls.checkinLinks.get(Params
                        .with("airlineCode", "BA"));

                Console.WriteLine(AmadeusUtil.ArrayToStringGeneric(checkinLinks, "\n"));

                Console.WriteLine("\n\n");

                Console.WriteLine("Get Locations:");

                amadeus.resources.Location[] locations = amadeus.referenceData.locations.get(Params
                    .with("keyword", "LON")
                    .and("subType", resources.referenceData.Locations.ANY));

                Console.WriteLine(AmadeusUtil.ArrayToStringGeneric(locations, "\n"));

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
            }
        }
    }
}
```

## Initialization

The client can be initialized directly.

```C#
//Initialize using parameters
Amadeus amadeus = Amadeus
        .builder("REPLACE_BY_YOUR_API_KEY", "REPLACE_BY_YOUR_API_SECRET")
        .build();
```

Alternatively it can be initialized without any parameters if the environment
variables `AMADEUS_CLIENT_ID` and `AMADEUS_CLIENT_SECRET` are present.

```C#
System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_ID", "REPLACE_BY_YOUR_API_KEY");
System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_ID", "REPLACE_BY_YOUR_API_SECRET");
Amadeus amadeus = Amadeus
        .builder()
        .build();
```

Your credentials can be found on the [Amadeus
dashboard](https://developers.amadeus.com/my-apps). [Sign
up](https://developers.amadeus.com/create-account) for an account today.

By default the environment for the SDK is the `test` environment. To switch to
a production (paid-for) environment please switch the hostname as follows:

```C#
Amadeus amadeus = Amadeus
        .builder()
        .setHostname("production")
        .build();
```

## Documentation

Amadeus has a large set of APIs, and our documentation is here to get you
started today. Head over to our
[Reference](https://amadeus4dev.github.io/amadeus-csharp/) documentation for
in-depth information about every SDK method, its arguments and return types.


* [Get Started](https://amadeus4dev.github.io/amadeus-csharp/) documentation
  * [Initialize the SDK](https://amadeus4dev.github.io/amadeus-csharp/)
  * [Find an Airport](https://amadeus4dev.github.io/amadeus-csharp/)
  * [Find a Flight](https://amadeus4dev.github.io/amadeus-csharp/)
  * [Get Flight Inspiration](https://amadeus4dev.github.io/amadeus-csharp/)

## Making API calls

This library conveniently maps every API path to a similar path.

For example, `GET /v2/reference-data/urls/checkin-links?airlineCode=BA` would be:

```C#
amadeus.referenceData.urls.checkinLinks.get(Params.with("airlineCode", "BA"));
```

Similarly, to select a resource by ID, you can pass in the ID to the **singular** path.

For example,  `GET /v2/shopping/hotel-offers/XXX` would be:

```C#
amadeus.hotelOffer("XXX").get(...);
```

You can make any arbitrary API call as well directly with the `.get` method.
Keep in mind, this returns a raw `Resource`

```C#
var result = amadeus.get("/v2/reference-data/urls/checkin-links",
  Params.with("airlineCode", "BA")).result();
```

## Response

Every successful API call returns a `Resource` object. The underlying
`Resource` with the raw available.

```C#
Location[] locations = amadeus.referenceData.locations.get(Params
  .with("keyword", "LON")
  .and("subType", Locations.ANY));

 // The raw response, as a string
locations[0].response.body;
```

## Pagination

If an API endpoint supports pagination, the other pages are available under the
`.next`, `.previous`, `.last` and `.first` methods.

```C#
Location[] locations = amadeus.referenceData.locations.get(Params
  .with("keyword", "LON")
  .and("subType", Locations.ANY));

// Fetches the next page
Location[] locations = (Location[]) amadeus.next(locations[0]);
```

If a page is not available, the method will return `null`.

## Logging & Debugging

The SDK makes it easy to add logger. To enable more verbose logging, you can set the appropriate level
on your own logger, though the easiest way would be to enable debugging via a
parameter on initialization, or using the `AMADEUS_LOG_LEVEL` environment
variable.

```C#
Amadeus amadeus = Amadeus
        .builder("REPLACE_BY_YOUR_API_KEY", "REPLACE_BY_YOUR_API_SECRET")
        .setLogLevel("debug") // or warn
        .build();
```

## List of supported endpoints
```java
// Flight Inspiration Search
FlightDestination[] flightDestinations = amadeus.shopping.flightDestinations.get(Params
  .with("origin", "MAD"));

// Flight Cheapest Date Search
FlightDate[] flightDates = amadeus.shopping.flightDates.get(Params
  .with("origin", "MAD")
  .and("destination", "MUC"));

// Flight Low-fare Search
FlightOffer[] flightOffers = amadeus.shopping.flightOffers.get(Params
  .with("origin", "NYC")
  .and("destination", "MAD")
  .and("departureDate", "2019-08-01"));

// Flight Check-in Links
CheckinLink[] checkinLinks = amadeus.referenceData.urls.checkinLinks.get(Params
  .with("airlineCode", "BA"));

// Airline Code LookUp
Airline[] airlines = amadeus.referenceData.airlines.get(Params
  .with("airlineCodes", "BA"));

// Airport & City Search (autocomplete)
// Find all the cities and airports starting by the keyword 'LON'
Location[] locations = amadeus.referenceData.locations.get(Params
  .with("keyword", "LON")
  .and("subType", Locations.ANY));
// Get a specific city or airport based on its id
Location location = amadeus.referenceData
  .location("ALHR").get();

// Airport Nearest Relevant (for London)
Location[] locations = amadeus.referenceData.locations.airports.get(Params
  .with("latitude", 0.1278)
  .and("longitude", 51.5074));

// Flight Most Searched Destinations
// Which were the most searched flight destinations from Madrid in August 2017?
SearchedDestination searchedDestination = amadeus.travel.analytics.airTraffic.searchedByDestination.get(Params
        .with("originCityCode", "MAD")
        .and("destinationCityCode", "NYC")
        .and("searchPeriod", "2017-08")
        .and("marketCountryCode", "ES"));
// How many people in Spain searched for a trip from Madrid to New-York in September 2017?
Search[] search = amadeus.travel.analytics.airTraffic.searched.get(Params
        .with("originCityCode", "MAD")
        .and("searchPeriod", "2017-08")
        .and("marketCountryCode", "ES"));

// Flight Most Booked Destinations
AirTraffic[] airTraffics = amadeus.travel.analytics.airTraffic.booked.get(Params
  .with("originCityCode", "MAD")
  .and("period", "2017-08"));

// Flight Most Traveled Destinations
AirTraffic[] airTraffics = amadeus.travel.analytics.airTraffic.traveled.get(Params
  .with("originCityCode", "MAD")
  .and("period", "2017-01"));

// Flight Busiest Traveling Period
Period[] busiestPeriods = amadeus.travel.analytics.airTraffic.busiestPeriod.get(Params
  .with("cityCode", "MAD")
  .and("period", "2017")
  .and("direction", BusiestPeriod.ARRIVING));

// Hotel Search API
// Get list of hotels by city code
HotelOffer[] offers = amadeus.shopping.hotelOffers.get(Params
  .with("cityCode", "MAD"));
// Get list of offers for a specific hotel
HotelOffer hotelOffer = amadeus.shopping.hotelOffersByHotel.get(Params.with("hotelId", "BGLONBGB"));
// Confirm the availability of a specific offer
HotelOffer offer = amadeus.shopping.hotelOffer("4BA070CE929E135B3268A9F2D0C51E9D4A6CF318BA10485322FA2C7E78C7852E").get();

// Points of Interest
// What are the popular places in Barcelona (based a geo location and a radius)
PointOfInterest[] pointsOfInterest = amadeus.referenceData.locations.pointsOfInterest.get(Params
   .with("latitude", "41.39715")
   .and("longitude", "2.160873"));

// What are the popular places in Barcelona? (based on a square)
PointOfInterest[] pointsOfInterest = amadeus.referenceData.locations.pointsOfInterest.bySquare.get(Params
    .with("north", "41.397158")
    .and("west", "2.160873")
    .and("south", "41.394582")
    .and("east", "2.177181"));
```

## Development & Contributing

Want to contribute? Read our [Contributors Guide](.github/CONTRIBUTING.md) for
guidance on installing and running this code in a development environment.


## License

This library is released under the [MIT License](LICENSE).

## Help

Our [developer support team](https://developers.amadeus.com/support) is here
to help you. You can find us on
[StackOverflow](https://stackoverflow.com/questions/tagged/amadeus) and
[email](mailto:developers@amadeus.com).

[support]: http://developers.amadeus.com/support
