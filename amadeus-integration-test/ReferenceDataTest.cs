using amadeus;
using amadeus.resources;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class ReferenceDataTest
    {
        [Fact]
        public void Get_Checkin_Links()
        {
            var amadeus = GetAmadeusBuild();
            CheckinLink[] checkinLinksList = amadeus.referenceData.urls.checkinLinks.get(Params
                        .with("airlineCode", "BA"));

            Assert.All(checkinLinksList, item => Assert.Contains(item.type, "checkin-link"));
            Assert.All(checkinLinksList, item => Assert.Contains("BA", item.id));
        }

        [Fact]
        public void Get_Locations()
        {
            var amadeus = GetAmadeusBuild();
            Location[] locations = amadeus.referenceData.locations.get(Params
                    .with("keyword", "LON")
                    .and("subType", resources.referenceData.Locations.ANY));

            Assert.All(locations, item => Assert.Contains(item.type, "location"));
        }

        [Fact]
        public void Get_Airlines()
        {
            var amadeus = GetAmadeusBuild();
            Airline[] airlines = amadeus.referenceData.airlines.get(Params
                    .with("airlineCodes", "BA"));

            Assert.All(airlines, item => Assert.Contains(item.type, "airline"));
        }
    }
}
