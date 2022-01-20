using amadeus;
using amadeus.resources;
using amadeus.travel.flightOffers;
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
            var flightOffersSearch = new FlightOffersSearch(amadeus);
            FlightOffer[] response = flightOffersSearch.getFlightOffers(Params.with("originLocationCode", "SYD").and("destinationLocationCode", "BKK")
                .and("departureDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd")).and("adults", "1"));

            Assert.True(response != null);
            Assert.True(response[0].type == "flight-offer");
        }
        
        [Fact]
        public void Post_FlightOffers()
        {
            var amadeus = GetAmadeusBuild();
            var flightOffersSearch = new FlightOffersSearch(amadeus);

            string body = "{\"data\":{\"type\":\"flight-offers-pricing\",\"flightOffers\":[{\"type\":\"flight-offer\",\"id\":\"1\",\"source\":\"GDS\",\"instantTicketingRequired\":false,\"nonHomogeneous\":false,\"oneWay\":false,\"lastTicketingDate\":\"2022-01-21\",\"numberOfBookableSeats\":7,\"itineraries\":[{\"duration\":\"PT5H49M\",\"segments\":[{\"departure\":{\"iataCode\":\"JFK\",\"terminal\":\"4\",\"at\":\"2022-02-01T10:31:00\"},\"arrival\":{\"iataCode\":\"LAX\",\"terminal\":\"2\",\"at\":\"2022-02-01T13:20:00\"},\"carrierCode\":\"DL\",\"number\":\"351\",\"aircraft\":{\"code\":\"764\"},\"operating\":{\"carrierCode\":\"DL\"},\"duration\":\"PT5H49M\",\"id\":\"30\",\"numberOfStops\":0,\"blacklistedInEU\":false}]}],\"price\":{\"currency\":\"EUR\",\"total\":\"121.33\",\"base\":\"101.00\",\"fees\":[{\"amount\":\"0.00\",\"type\":\"SUPPLIER\"},{\"amount\":\"0.00\",\"type\":\"TICKETING\"}],\"grandTotal\":\"121.33\"},\"pricingOptions\":{\"fareType\":[\"PUBLISHED\"],\"includedCheckedBagsOnly\":false},\"validatingAirlineCodes\":[\"DL\"],\"travelerPricings\":[{\"travelerId\":\"1\",\"fareOption\":\"STANDARD\",\"travelerType\":\"ADULT\",\"price\":{\"currency\":\"EUR\",\"total\":\"121.33\",\"base\":\"101.00\"},\"fareDetailsBySegment\":[{\"segmentId\":\"30\",\"cabin\":\"ECONOMY\",\"fareBasis\":\"TA7NA0BQ\",\"brandedFare\":\"BASICECON\",\"class\":\"E\",\"includedCheckedBags\":{\"quantity\":0}}]}]}]}}";
            FlightOffer[] response = flightOffersSearch.postFlightOffers(Params.with("getFlightOffersBody", body));

            Assert.True(response != null);
            Assert.True(response[0].type == "flight-offer");
        }

        [Fact]
        public void Post_FlightOffersPricing()
        {
            var amadeus = GetAmadeusBuild();
            var flightOffersPricing = new FlightOffersPricing(amadeus);

            /*var flightOffersSearch = new FlightOffersSearch(amadeus);
            FlightOffer[] flightOffersSearches = flightOffersSearch.getFlightOffers(Params.with("originLocationCode", "SYD")
            .and("destinationLocationCode", "BKK")
            .and("departureDate", "2022-11-01")
            .and("returnDate", "2022-11-08")
            .and("adults", "1")
            .and("max", "2"));

            var json = JsonConvert.SerializeObject(flightOffersSearches[1]);*/

            string body = "{\"data\":{\"type\":\"flight-offers-pricing\",\"flightOffers\":[{\"type\":\"flight-offer\",\"id\":\"1\",\"source\":\"GDS\",\"instantTicketingRequired\":false,\"nonHomogeneous\":false,\"oneWay\":false,\"lastTicketingDate\":\"2022-01-21\",\"numberOfBookableSeats\":7,\"itineraries\":[{\"duration\":\"PT5H49M\",\"segments\":[{\"departure\":{\"iataCode\":\"JFK\",\"terminal\":\"4\",\"at\":\"2022-02-01T10:31:00\"},\"arrival\":{\"iataCode\":\"LAX\",\"terminal\":\"2\",\"at\":\"2022-02-01T13:20:00\"},\"carrierCode\":\"DL\",\"number\":\"351\",\"aircraft\":{\"code\":\"764\"},\"operating\":{\"carrierCode\":\"DL\"},\"duration\":\"PT5H49M\",\"id\":\"30\",\"numberOfStops\":0,\"blacklistedInEU\":false}]}],\"price\":{\"currency\":\"EUR\",\"total\":\"121.33\",\"base\":\"101.00\",\"fees\":[{\"amount\":\"0.00\",\"type\":\"SUPPLIER\"},{\"amount\":\"0.00\",\"type\":\"TICKETING\"}],\"grandTotal\":\"121.33\"},\"pricingOptions\":{\"fareType\":[\"PUBLISHED\"],\"includedCheckedBagsOnly\":false},\"validatingAirlineCodes\":[\"DL\"],\"travelerPricings\":[{\"travelerId\":\"1\",\"fareOption\":\"STANDARD\",\"travelerType\":\"ADULT\",\"price\":{\"currency\":\"EUR\",\"total\":\"121.33\",\"base\":\"101.00\"},\"fareDetailsBySegment\":[{\"segmentId\":\"30\",\"cabin\":\"ECONOMY\",\"fareBasis\":\"TA7NA0BQ\",\"brandedFare\":\"BASICECON\",\"class\":\"E\",\"includedCheckedBags\":{\"quantity\":0}}]}]}]}}";
            FlightOfferPricingOutput[] response = flightOffersPricing.postFlightOffersPricing(Params.with("priceFlightOffersBody ", body));

            Assert.True(response != null);
            Assert.True(response[0].type == "flight-offers-pricing");

        }

        private string getQuery()
        {
            GetFlightOffersQuery obj = new GetFlightOffersQuery();
            obj.currencyCode = "USD";
            obj.originDestinations = new List<OriginDestination>();
            OriginDestination originDestination = new OriginDestination();
            originDestination.id = "1";
            originDestination.originLocationCode = "RIO";
            originDestination.originLocationCode = "MAD";
            DateTimeRange dateTimeRange = new DateTimeRange(); ;
            dateTimeRange.date = System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd");
            dateTimeRange.time = "10:00:00";
            originDestination.departureDateTimeRange = dateTimeRange;
            obj.originDestinations.Add(originDestination);
            obj.travelers = new List<TravelerInfo>();
            TravelerInfo travelerInfo = new TravelerInfo();
            travelerInfo.id = "1";
            travelerInfo.travelerType = "ADULT";
            obj.travelers.Add(travelerInfo);
            obj.sources = new List<SourcesFlight>();
            SourcesFlight sourcesFlight = new SourcesFlight();
            sourcesFlight.FlightOfferSource = "GDS";
            obj.sources.Add(sourcesFlight);
            obj.searchCriteria = new SearchCriteria();
            obj.searchCriteria.maxFlightOffers = 2;
            obj.searchCriteria.flightFilters = new FlightFilters();
            obj.searchCriteria.flightFilters.cabinRestrictions = new List<CabinRestriction>();
            CabinRestriction cabinRestriction = new CabinRestriction();
            cabinRestriction.cabin = "BUSINESS";
            cabinRestriction.coverage = "MOST_SEGMENTS";
            cabinRestriction.originDestinationIds = new List<string>();
            cabinRestriction.originDestinationIds.Add("1");
            obj.searchCriteria.flightFilters.cabinRestrictions.Add(cabinRestriction);
            obj.searchCriteria.flightFilters.carrierRestrictions = new CarrierRestrictions();
            obj.searchCriteria.flightFilters.carrierRestrictions.excludedCarrierCodes = new List<string>();
            obj.searchCriteria.flightFilters.carrierRestrictions.excludedCarrierCodes.Add("AA");
            obj.searchCriteria.flightFilters.carrierRestrictions.excludedCarrierCodes.Add("TP");
            obj.searchCriteria.flightFilters.carrierRestrictions.excludedCarrierCodes.Add("AZ");

            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        private string getPricingQuery()
        {
            FlightOfferPricingInput obj = new FlightOfferPricingInput();

            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        
    }
}
