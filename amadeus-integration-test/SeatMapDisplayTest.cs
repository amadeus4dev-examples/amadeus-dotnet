using amadeus;
using amadeus.resources;
using amadeus.shopping;
using System;
using System.Collections.Generic;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class SeatMapDisplayTest
    {
        [Fact]
        public void Get_SeatMap()
        {
            var amadeus = GetAmadeusBuild();
            SeatMap[] response = amadeus.shopping.seatmaps.getSeatMap(Params.with("flightOrderId", "MlpZVkFMfFdBVFNPTnwyMDE1LTExLTAy"));

            Assert.True(response != null);
        }

        [Fact]
        public void Post_SeatMap()
        {
            var amadeus = GetAmadeusBuild();

            var flightOffersSearch = new FlightOffersSearch(amadeus);
            FlightOffer[] flightOffersSearches = amadeus.shopping.flightOffersSearch.getFlightOffers(Params.with("originLocationCode", "SYD")
            .and("destinationLocationCode", "BKK")
            .and("departureDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd"))
            .and("returnDate", System.DateTime.Now.AddMonths(3).ToString("yyyy-MM-dd"))                                                                                                                                                                             
            .and("adults", "1")
            .and("max", "2"));
            string body = "{\"data\":[" + flightOffersSearches[0].response.data[0] + "]}}";
            
            SeatMap[] response = amadeus.shopping.seatmaps.postSeatMap(body);

            Assert.True(response != null);
            //Assert.True(response[0].type == "seatmap");

        }
    }
}
