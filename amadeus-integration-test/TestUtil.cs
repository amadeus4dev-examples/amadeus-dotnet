using amadeus;
using System;

namespace amadeus_integration_test
{
    public static class TestUtil
    {
        private static readonly string API_KEY = "GrITQAe6RPnTRjLFNT6Pg5IxKyzPJdVs";
        private static readonly string API_SECRET = "xeGNPqV1VDh1VqEz";

        public static Amadeus GetAmadeusBuild()
        {
            //Configuration amadeusconfig = Amadeus.builder(Environment.GetEnvironmentVariable("key"), Environment.GetEnvironmentVariable("secret"));
            Configuration amadeusconfig = Amadeus.builder(API_KEY, API_SECRET);

            amadeusconfig.setLoglevel("debug");
            return amadeusconfig.build();
        }
    }
}
