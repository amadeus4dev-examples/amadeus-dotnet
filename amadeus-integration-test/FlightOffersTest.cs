using amadeus;
using amadeus.resources;
using amadeus.shopping;
using amadeus.shopping.flightOffers;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class FlightOffersTest
    {
        [Fact]
        public void Get_FlightOffers()
        {
            var amadeus = GetAmadeusBuild();
            FlightOffer[] response = amadeus.shopping.flightOffersSearch.getFlightOffers(Params.with("originLocationCode", "SYD").and("destinationLocationCode", "BKK")
                .and("departureDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd")).and("adults", "1"));

            Assert.True(response != null);
            Assert.True(response[0].type == "flight-offer");
        }
        
        [Fact]
        public void Post_FlightOffers()
        {
            var amadeus = GetAmadeusBuild();
            string body = "{\"originDestinations\":[{\"id\":\"1\",\"originLocationCode\":\"RIO\",\"destinationLocationCode\":\"MAD\",\"departureDateTimeRange\":{\"date\":\"" + System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd") + "\",\"time\":\"10:00:00\"}}],\"travelers\":[{\"id\":\"1\",\"travelerType\":\"ADULT\"}],\"sources\":[\"GDS\"]}";
            FlightOffer[] response = amadeus.shopping.flightOffersSearch.postFlightOffers(body);

            Assert.True(response != null);
            Assert.True(response[0].type == "flight-offer");
        }

        [Fact]
        public void Post_FlightOffersPricing()
        {
            var amadeus = GetAmadeusBuild();
            FlightOffer[] flightOffersSearches = amadeus.shopping.flightOffersSearch.getFlightOffers(Params.with("originLocationCode", "SYD")
            .and("destinationLocationCode", "BKK")
            .and("departureDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd"))
            .and("adults", "1")
            .and("max", "2"));

            string body = "{\"data\":{\"type\":\"flight-offers-pricing\",\"flightOffers\":[" + flightOffersSearches[0].response.data[0] + "]}}";
            FlightOfferPricingOutput response = amadeus.shopping.flightOffers.pricing.postFlightOffersPricing(new Params(), body);

            Assert.True(response != null);
            Assert.True(response.type == "flight-offers-pricing");

        }
    }
}
