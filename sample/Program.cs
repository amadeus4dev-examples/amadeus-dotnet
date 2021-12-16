using System;
using System.IO;
using System.Net;
using System.Text;
using amadeus;
using amadeus.util;

namespace amadeustest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetLocations();
        }

        public static void GetLocations()
        {
            try
            {

                var apikey = "YOUR_AMADEUS_API_KEY";
                var apisecret = "YOUR_AMADEUS_API_SECRET";

                Configuration amadeusconfig = Amadeus.builder(apikey, apisecret);
                amadeusconfig.setLoglevel("debug");
                Amadeus amadeus = amadeusconfig.build();

                Console.WriteLine("Get CheckinLink:");
                amadeus.resources.CheckinLink[] checkinLinks = amadeus.referenceData.urls.checkinLinks.get(Params
                        .with("airlineCode", "BA"));

                Console.WriteLine(AmadeusUtil.ArrayToStringGeneric(checkinLinks, "\n"));

                Console.WriteLine("\n\n");

                Console.WriteLine("Get Locations:");

                amadeus.resources.Location[] locations = amadeus.referenceData.locations.get(Params
                    .with("keyword", "LON")
                    .and("subType", resources.referenceData.Locations.ANY));


                Console.WriteLine(AmadeusUtil.ArrayToStringGeneric(locations, "\n"));

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
            }
        }
    }
}

