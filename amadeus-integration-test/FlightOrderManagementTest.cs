using amadeus;
using amadeus.resources;
using amadeus.booking;
using System;
using System.Collections.Generic;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class FlightOrderManagementTest
    {
        /*[Fact]
        public void Get_FlightOrderManagement()
        {
            var amadeus = GetAmadeusBuild();
            FlightOrderCreateQuery response = amadeus.booking.flightOrderManagement.getFlightOrderManagement(Params.with("flight-orderId", "eJzTd9cPsbR083cDAArgAkc%3D"));

            Assert.True(response != null);
            Assert.True(response.type == "flight-order");
        }*/

        /*[Fact]
        public void Post_FlightOrderManagement()
        {
            var amadeus = GetAmadeusBuild();
            string body = "{\"data\":{\"type\":\"flight-order\",\"flightOffers\":[{\"type\":\"flight-offer\",\"id\":\"1\",\"source\":\"GDS\",\"instantTicketingRequired\":false,\"nonHomogeneous\":false,\"oneWay\":false,\"lastTicketingDate\":\"2022-01-21\",\"numberOfBookableSeats\":7,\"itineraries\":[{\"duration\":\"PT5H49M\",\"segments\":[{\"departure\":{\"iataCode\":\"JFK\",\"terminal\":\"4\",\"at\":\"2022-02-01T10:31:00\"},\"arrival\":{\"iataCode\":\"LAX\",\"terminal\":\"2\",\"at\":\"2022-02-01T13:20:00\"},\"carrierCode\":\"DL\",\"number\":\"351\",\"aircraft\":{\"code\":\"764\"},\"operating\":{\"carrierCode\":\"DL\"},\"duration\":\"PT5H49M\",\"id\":\"30\",\"numberOfStops\":0,\"blacklistedInEU\":false}]}],\"price\":{\"currency\":\"EUR\",\"total\":\"122.53\",\"base\":\"101.00\",\"fees\":[{\"amount\":\"0.00\",\"type\":\"SUPPLIER\"},{\"amount\":\"0.00\",\"type\":\"TICKETING\"}],\"grandTotal\":\"122.53\"},\"pricingOptions\":{\"fareType\":[\"PUBLISHED\"],\"includedCheckedBagsOnly\":false},\"validatingAirlineCodes\":[\"DL\"],\"travelerPricings\":[{\"travelerId\":\"1\",\"fareOption\":\"STANDARD\",\"travelerType\":\"ADULT\",\"price\":{\"currency\":\"EUR\",\"total\":\"122.53\",\"base\":\"101.00\"},\"fareDetailsBySegment\":[{\"segmentId\":\"30\",\"cabin\":\"ECONOMY\",\"fareBasis\":\"TA7NA0BQ\",\"brandedFare\":\"BASICECON\",\"class\":\"E\",\"includedCheckedBags\":{\"quantity\":0}}]}]}],\"travelers\":[{\"id\":\"1\",\"dateOfBirth\":\"1987-07-22\",\"name\":{\"firstName\":\"amir\",\"lastName\":\"taheri\"},\"gender\":\"MALE\",\"documents\":[{\"documentType\":\"PASSPORT\",\"number\":\"J12345678\",\"expiryDate\":\"2024-02-22\",\"issuanceCountry\":\"TR\",\"nationality\":\"TR\",\"holder\":true}]}],\"contacts\":[{\"companyName\":\"INCREIBLEVIAJES\",\"purpose\":\"STANDARD\",\"phones\":[{\"deviceType\":\"LANDLINE\",\"countryCallingCode\":\"34\",\"number\":\"480080071\"},{\"deviceType\":\"MOBILE\",\"countryCallingCode\":\"33\",\"number\":\"480080072\"}],\"emailAddress\":\"support@increibleviajes.es\"}]}}";
            
            FlightOrderCreateQuery response = amadeus.booking.flightOrderManagement.postFlightOrderManagement(body);

            Assert.True(response != null);
            //Assert.True(restriction[0].type == "flight-order");

        }*/

        /*[Fact]
        public void Delete_FlightOrderManagement()
        {
            var amadeus = GetAmadeusBuild();
            FlightOrderCreateQuery[] response = amadeus.booking.flightOrderManagement.deleteFlightOrderManagement(Params.with("flight-orderId", "eJzTd9cPsbR083cDAArgAkc%3D"));

            Assert.True(response != null);
            

        }*/
    }
}
