using amadeus;
using Moq;
using NUnit.Framework;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using resources.referenceData.urls;
using resources.referenceData;
using resources.referenceData.locations;
using amadeus.travel.analytics.airTraffic;
using amadeus.shopping;

namespace amadeustest
{
    [TestFixture()]
    public class NamespaceTest
    {


        [Test()]
        public void TestAllNamespacesExist()
        {
            Amadeus client = Amadeus.builder("id", "secret").build();
            Assert.IsNotNull(client.referenceData.urls.checkinLinks);
            Assert.IsNotNull(client.referenceData.locations.airports);
            Assert.IsNotNull(client.referenceData.location("123"));
            Assert.IsNotNull(client.referenceData.airlines);
            Assert.IsNotNull(client.travel.analytics.airTraffic.traveled);
            Assert.IsNotNull(client.travel.analytics.airTraffic.booked);
            Assert.IsNotNull(client.travel.analytics.airTraffic.searched);
            Assert.IsNotNull(client.travel.analytics.airTraffic.searchedByDestination);
            Assert.IsNotNull(client.shopping.flightDates);
            Assert.IsNotNull(client.shopping.flightDestinations);
            Assert.IsNotNull(client.shopping.flightOffers);
            Assert.IsNotNull(client.shopping.hotelOffers);
            Assert.IsNotNull(client.shopping.hotelOffersByHotel);
            Assert.IsNotNull(client.shopping.hotelOffer("XXX"));
        }


        [Test()]
        public void TestGetMethods()
        {
            var _client = new Mock<Amadeus>();
            var _params = Params.with("airline", "1X");

            // Prepare a plural response
            JArray jsonArray = new JArray();
            jsonArray.Add(new JObject());
            jsonArray.Add(new JObject());
            var _multiResponse = new Mock<Response>();
            _multiResponse.Setup(m => m.parsed).Returns(true);
            _multiResponse.Setup(m => m.data).Returns(jsonArray);
            _multiResponse.Setup(m => m.dataString).Returns(jsonArray.ToString());

            // Prepare a single response
            JObject jsonObject = new JObject();
            jsonObject.Add("foo", "bar");
            var _singleResponse = new Mock<Response>();
            _singleResponse.Setup(m => m.parsed).Returns(true);
            _singleResponse.Setup(m => m.data).Returns(jsonObject);
            _singleResponse.Setup(m => m.dataString).Returns(jsonObject.ToString());

            try
            {
                // Testing CheckinLinks
                _client.Setup(m => m.get("/v2/reference-data/urls/checkin-links", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v2/reference-data/urls/checkin-links", _params)).Returns(_multiResponse.Object);
                CheckinLinks checkinLinks = new CheckinLinks(_client.Object);
                Assert.IsNotNull(checkinLinks);
                Assert.IsNotNull(checkinLinks.get(_params));
                Assert.IsTrue(checkinLinks.get().Length == 2);

                // Testing location search
                _client.Setup(m => m.get("/v1/reference-data/locations", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/reference-data/locations", _params)).Returns(_multiResponse.Object);
                Locations locations = new Locations(_client.Object);
                Assert.IsNotNull(locations);
                Assert.IsNotNull(locations.get(_params));
                Assert.IsTrue(locations.get().Length == 2);

                // Testing airport search
                _client.Setup(m => m.get("/v1/reference-data/locations/airports", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/reference-data/locations/airports", _params)).Returns(_multiResponse.Object);
                Airports airports = new Airports(_client.Object);
                Assert.IsNotNull(airports);
                Assert.IsNotNull(airports.get(_params));
                Assert.IsTrue(airports.get().Length == 2);

                // Testing fetching a single location
                _client.Setup(m => m.get("/v1/reference-data/locations/ALHR", null)).Returns(_singleResponse.Object);
                _client.Setup(m => m.get("/v1/reference-data/locations/ALHR", _params)).Returns(_singleResponse.Object);
                Location location = new Location(_client.Object, "ALHR");
                Assert.IsNotNull(location);
                Assert.IsNotNull(location.get(_params));

                // Testing airlines search
                _client.Setup(m => m.get("/v1/reference-data/airlines", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/reference-data/airlines", _params)).Returns(_multiResponse.Object);
                Airlines airlines = new Airlines(_client.Object);
                Assert.IsNotNull(airlines);
                Assert.IsNotNull(airlines.get(_params));
                Assert.IsTrue(airlines.get().Length == 2);

                // Testing traveled stats
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/traveled", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/traveled", _params)).Returns(_multiResponse.Object);
                Traveled traveled = new Traveled(_client.Object);
                Assert.IsNotNull(traveled);
                Assert.IsNotNull(traveled.get(_params));
                Assert.IsTrue(traveled.get().Length == 2);

                // Testing booked stats
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/booked", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/booked", _params)).Returns(_multiResponse.Object);
                Booked booked = new Booked(_client.Object);
                Assert.IsNotNull(booked);
                Assert.IsNotNull(booked.get(_params));
                Assert.IsTrue(booked.get().Length == 2);

                // Testing busiest traveling period
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/busiest-period", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/busiest-period", _params)).Returns(_multiResponse.Object);
                BusiestPeriod busiestPeriod = new BusiestPeriod(_client.Object);
                Assert.IsNotNull(busiestPeriod);
                Assert.IsNotNull(busiestPeriod.get(_params));
                Assert.IsTrue(busiestPeriod.get().Length == 2);

                // Testing most searched destinations
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/searched", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/searched", _params)).Returns(_multiResponse.Object);
                Searched searched = new Searched(_client.Object);
                Assert.IsNotNull(searched);
                Assert.IsNotNull(searched.get(_params));
                Assert.IsTrue(searched.get().Length == 2);

                // Testing searched stats
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/searched/by-destination", null)).Returns(_singleResponse.Object);
                _client.Setup(m => m.get("/v1/travel/analytics/air-traffic/searched/by-destination", _params)).Returns(_singleResponse.Object);
                SearchedByDestination searchesByDestination = new SearchedByDestination(_client.Object);
                Assert.IsNotNull(searchesByDestination);
                Assert.IsNotNull(searchesByDestination.get(_params));

                // Testing most searched destinations
                _client.Setup(m => m.get("/v1/shopping/flight-dates", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/shopping/flight-dates", _params)).Returns(_multiResponse.Object);
                FlightDates flightDates = new FlightDates(_client.Object);
                Assert.IsNotNull(flightDates);
                Assert.IsNotNull(flightDates.get(_params));
                Assert.IsTrue(flightDates.get().Length == 2);

                // Testing flight destination search
                _client.Setup(m => m.get("/v1/shopping/flight-destinations", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v1/shopping/flight-destinations", _params)).Returns(_multiResponse.Object);
                FlightDestinations flightDestinations = new FlightDestinations(_client.Object);
                Assert.IsNotNull(flightDestinations);
                Assert.IsNotNull(flightDestinations.get(_params));
                Assert.IsTrue(flightDestinations.get().Length == 2);

                // Testing flight offer search
                _client.Setup(m => m.get("/v2/shopping/flight-offers", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v2/shopping/flight-offers", _params)).Returns(_multiResponse.Object);
                FlightOffers flightOffers = new FlightOffers(_client.Object);
                Assert.IsNotNull(flightOffers);
                Assert.IsNotNull(flightOffers.get(_params));
                Assert.IsTrue(flightOffers.get().Length == 2);

                // Testing hotel offer search
                _client.Setup(m => m.get("/v2/shopping/hotel-offers", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v2/shopping/hotel-offers", _params)).Returns(_multiResponse.Object);
                HotelOffers hotelOffers = new HotelOffers(_client.Object);
                Assert.IsNotNull(hotelOffers);
                Assert.IsNotNull(hotelOffers.get(_params));
                Assert.IsTrue(hotelOffers.get().Length == 2);

                // Testing hotel offer search for a hotel
                _client.Setup(m => m.get("/v2/shopping/hotel-offers/by-hotel", null)).Returns(_multiResponse.Object);
                _client.Setup(m => m.get("/v2/shopping/hotel-offers/by-hotel", _params)).Returns(_multiResponse.Object);
                HotelOffersByHotel hotelOffersByHotel = new HotelOffersByHotel(_client.Object);
                Assert.IsNotNull(hotelOffersByHotel);
                Assert.IsNotNull(hotelOffersByHotel.get(_params));
                Assert.IsTrue(hotelOffersByHotel.get().Length == 2);

                // Test fetching a specific offer
                _client.Setup(m => m.get("/v2/shopping/hotel-offers/XXX", null)).Returns(_singleResponse.Object);
                _client.Setup(m => m.get("/v2/shopping/hotel-offers/XXX", _params)).Returns(_singleResponse.Object);
                HotelOffer hotelOffer = new HotelOffer(_client.Object, "XXX");
                Assert.IsNotNull(hotelOffer);
                Assert.IsNotNull(hotelOffer.get(_params));


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Assert.Fail();
            }
        }


    }

}
