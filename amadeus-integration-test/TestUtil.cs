using amadeus;

namespace amadeus_integration_test
{
    public static class TestUtil
    {
        private static readonly string API_KEY = "FGsfeaT5TPuEyVlKhY8O0OrVGpDCqK40";
        private static readonly string API_SECRET = "K2riEqWxiodl9XcQ";

        public static Amadeus GetAmadeusBuild()
        {
            Configuration amadeusconfig = Amadeus.builder(API_KEY, API_SECRET);
            amadeusconfig.setLoglevel("debug");
            return amadeusconfig.build();
        }
    }
}
