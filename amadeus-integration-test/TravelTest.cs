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
            Prediction response = amadeus.travel.predictions.tripPurpose.get(Params.with("originLocationCode", "NYC")
                .and("destinationLocationCode", "MAD")
                .and("departureDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd"))
                .and("returnDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd"))
                .and("searchDate", System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd")));

            Assert.True(response != null);
            Assert.True(response.subType == "trip-purpose");
            Assert.True(response.type == "prediction");
        }
    }
}
