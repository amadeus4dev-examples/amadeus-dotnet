using amadeus;
using amadeus.resources;
using amadeus.dutyOfcare;

using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class TravelRestrictionsTest
    {
        [Fact]
        public void Get_Restrictions()
        {
            var amadeus = GetAmadeusBuild();
            DiseaseAreaReport response = amadeus.referenceData.dutyOfCare.travelRestrictions.get(Params.with("countryCode", "US"));

            Assert.True(response != null);
            Assert.True(response.type == "covid19-area-report");
        }
    }
}
