using amadeus;
using System;

namespace amadeus_integration_test
{
    public static class TestUtil
    {
        private static readonly string API_KEY = "YOUR_AMADEUS_API_KEY";
        private static readonly string API_SECRET = "YOUR_AMADEUS_API_SECRET";

        public static Amadeus GetAmadeusBuild()
        {
            Configuration amadeusconfig = Amadeus.builder(Environment.GetEnvironmentVariable("key"), Environment.GetEnvironmentVariable("secret"));
            //Configuration amadeusconfig = Amadeus.builder(API_KEY, API_SECRET);

            amadeusconfig.setLoglevel("debug");
            return amadeusconfig.build();
        }
    }
}
