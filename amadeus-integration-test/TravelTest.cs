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
                .and("departureDate", System.DateTime.Now.ToString("yyyy-MM-dd"))
                .and("returnDate", System.DateTime.Now.ToString("yyyy-MM-dd"))
                .and("searchDate", System.DateTime.Now.ToString("yyyy-MM-dd")));

            Assert.True(prediction != null);
            Assert.True(prediction.subType == "trip-purpose");
            Assert.True(prediction.type == "prediction");
        }
    }
}
