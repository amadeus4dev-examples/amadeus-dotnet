using amadeus;
using amadeus.resources;
using amadeus.travel.restrictions;
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
            var safePlace = new SafePlace(amadeus);
            SafetyRatedLocation[] safeLocation = safePlace.getByGeoCode(Params.with("latitude", "41.397158").and("longitude", "2.160873"));

            Assert.True(safeLocation != null);
            Assert.True(safeLocation[0].type == "safety-rated-location");
        }

        [Fact]
        public void Get_Safety_Locations_by_Square()
        {
            var amadeus = GetAmadeusBuild();
            var safePlace = new SafePlace(amadeus);
            SafetyRatedLocation[] safeLocation = safePlace.getBySquare(Params.with("north", "41.397158").and("west", "2.160873").and("south", "41.394582").and("east", "2.177181"));

            Assert.True(safeLocation != null);
            Assert.True(safeLocation[0].type == "safety-rated-location");
        }


        [Fact]
        public void Get_Safety_Locations_by_Id()
        {
            var amadeus = GetAmadeusBuild();
            var safePlace = new SafePlace(amadeus);
            SafetyRatedLocation safeLocation = safePlace.getById(Params.with("safety-rated-locationId", "Q930402719"));

            Assert.True(safeLocation != null);
            Assert.True(safeLocation.type == "safety-rated-location");
        }
    }
}
