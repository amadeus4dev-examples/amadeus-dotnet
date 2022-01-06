using amadeus;
using amadeus.resources;
using amadeus.travel.predictions;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class TravelTest
    {
        [Fact]
        public void Get_Prediction()
        {
            var amadeus = GetAmadeusBuild();
            var tripPurpose = new TripPurpose(amadeus);
            Prediction prediction = tripPurpose.get(Params.with("originLocationCode", "NYC")
                .and("destinationLocationCode", "MAD")
                .and("departureDate", "2022-01-01")
                .and("returnDate", "2022-01-06")
                .and("searchDate", "2021-12-25"));

            Assert.True(prediction != null);
            Assert.True(prediction.subType == "trip-purpose");
            Assert.True(prediction.type == "prediction");
        }
    }
}
