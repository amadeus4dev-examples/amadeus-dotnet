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
            DiseaseAreaReport response = amadeus.dutyOfCare.diseases.covid19AreaReport.get(Params
                .with("countryCode", "US")
                .and("cityCode", "NYC")
                .and("language", "EN"));

            Assert.True(response != null);
            Assert.True(response.type == "covid19-area-report");
        }
    }
}
