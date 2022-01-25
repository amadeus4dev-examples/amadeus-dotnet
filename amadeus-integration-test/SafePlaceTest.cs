using amadeus;
using amadeus.resources;
using amadeus.safety;
using System;
using System.Collections.Generic;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class SafePlaceTest
    {
        [Fact]
        public void Get_Safety_Locations()
        {
            var amadeus = GetAmadeusBuild();
            SafetyRatedLocation[] response = amadeus.referenceData.safety.safePlace.getByGeoCode(Params.with("latitude", "41.397158").and("longitude", "2.160873"));

            Assert.True(response != null);
            Assert.True(response[0].type == "safety-rated-location");
        }

        [Fact]
        public void Get_Safety_Locations_by_Square()
        {
            var amadeus = GetAmadeusBuild();
            SafetyRatedLocation[] response = amadeus.referenceData.safety.safePlace.getBySquare(Params.with("north", "41.397158").and("west", "2.160873").and("south", "41.394582").and("east", "2.177181"));

            Assert.True(response != null);
            Assert.True(response[0].type == "safety-rated-location");
        }


        [Fact]
        public void Get_Safety_Locations_by_Id()
        {
            var amadeus = GetAmadeusBuild();
            SafetyRatedLocation response = amadeus.referenceData.safety.safePlace.getById(Params.with("safety-rated-locationId", "Q930402719"));

            Assert.True(response != null);
            Assert.True(response.type == "safety-rated-location");
        }
    }
}
