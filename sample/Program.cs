using amadeus;
using amadeus.resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var apikey = "TGtBxDVdQRbbn3NzER3QDYlN6N6x4RNR";
                var apisecret = "yJ6G7lGrlEO3LABl";

                Configuration amadeusconfig = Amadeus.builder(apikey, apisecret);
                amadeusconfig.setLoglevel("debug");
                Amadeus amadeus = amadeusconfig.build();

                string body = @"{
    ""currencyCode"": ""EGP"",
    ""originDestinations"": [
        {
            ""id"": ""1"",
            ""originLocationCode"": ""CAI"",
            ""destinationLocationCode"": ""JED"",
            ""departureDateTimeRange"": {
                ""date"": ""2023-12-01"",
                ""time"": ""10:00:00""
            }
        },
        {
            ""id"": ""2"",
            ""originLocationCode"": ""JED"",
            ""destinationLocationCode"": ""CAI"",
            ""departureDateTimeRange"": {
                ""date"": ""2023-12-20"",
                ""time"": ""10:00:00""
            }
        }
    ],
    ""travelers"": [
        {
            ""id"": ""1"",
            ""travelerType"": ""ADULT""
        },
        {
            ""id"": ""2"",
            ""travelerType"": ""ADULT""
        }
    ],
    ""sources"": [
        ""GDS""
    ],
    ""searchCriteria"": {
        ""maxFlightOffers"": 5,
        ""flightFilters"": {
            ""cabinRestrictions"": [
                {
                    ""cabin"": ""ECONOMY"",
                    ""coverage"": ""MOST_SEGMENTS"",
                    ""originDestinationIds"": [
                        ""1""
                    ]
                }
            ]
        }
    }
}";
                FlightOffer[] flights = amadeus.shopping.flightOffersSearch.postFlightOffers(body);
                FlightOfferPricingInput flightOfferPricingInput = new FlightOfferPricingInput
                {
                    type = "flight-offers-pricing",
                    flightOffers = new List<FlightOffer> { flights[0] }
                };
                string x = JsonConvert.SerializeObject(new { data = flightOfferPricingInput });
                FlightOfferPricingOutput flightOfferPricingOutput = amadeus.shopping.flightOffers.pricing
                    .postFlightOffersPricing(JsonConvert.SerializeObject(new { data = flightOfferPricingInput }));

                
                FlightOrderCreateQuery response = amadeus.booking.flightOrder
                    .postFlightOrderManagement(JsonConvert.SerializeObject(new
                    {
                        data = new
                        {
                            type = "flight-order",
                            flightOffers = flightOfferPricingOutput.flightOffers.ToList(),
                            travelers = new[]
                            {
                                new
                                {
                                    id = "1",
                                    dateOfBirth = "1982-01-16",
                                    name = new
                                    {
                                        firstName = "JORGE",
                                        lastName = "GONZALES"
                                    },
                                    gender = "MALE",
                                    contact = new
                                    {
                                        emailAddress = "jorge.gonzales833@telefonica.es",
                                        phones = new[]
                                        {
                                            new
                                            {
                                                deviceType = "MOBILE",
                                                countryCallingCode = "34",
                                                number = "480080076"
                                            }
                                        }
                                    },
                                    documents = new[]
                                    {
                                        new
                                        {
                                            documentType = "PASSPORT",
                                            birthPlace = "Madrid",
                                            issuanceLocation = "Madrid",
                                            issuanceDate = "2015-04-14",
                                            number = "00000000",
                                            expiryDate = "2025-04-14",
                                            issuanceCountry = "ES",
                                            validityCountry = "ES",
                                            nationality = "ES",
                                            holder = true
                                        }
                                    }
                                },
                                new
                                {
                                    id = "2",
                                    dateOfBirth = "1982-01-16",
                                    name = new
                                    {
                                        firstName = "Abdo",
                                        lastName = "GONZALES"
                                    },
                                    gender = "MALE",
                                    contact = new
                                    {
                                        emailAddress = "jorge.gonzales833@telefonica.es",
                                        phones = new[]
                                        {
                                            new
                                            {
                                                deviceType = "MOBILE",
                                                countryCallingCode = "34",
                                                number = "480080176"
                                            }
                                        }
                                    },
                                    documents = new[]
                                    {
                                        new
                                        {
                                            documentType = "PASSPORT",
                                            birthPlace = "Madrid",
                                            issuanceLocation = "Madrid",
                                            issuanceDate = "2015-04-14",
                                            number = "00000000",
                                            expiryDate = "2025-04-14",
                                            issuanceCountry = "ES",
                                            validityCountry = "ES",
                                            nationality = "ES",
                                            holder = true
                                        }
                                    }
                                }
                            },
                            remarks = new
                            {
                                general = new[]
                                {
                                    new
                                    {
                                        subType = "GENERAL_MISCELLANEOUS",
                                        text = "ONLINE BOOKING FROM INCREIBLE VIAJES"
                                    }
                                }
                            },
                            ticketingAgreement = new
                            {
                                option = "CONFIRM",
                                delay = "6D"
                            },
                            contacts = new[]
                            { 
                                new
                                {
                                    addresseeName = new
                                    {
                                        firstName = "PABLO",
                                        lastName = "RODRIGUEZ"
                                    },
                                    companyName = "INCREIBLE VIAJES",
                                    purpose = "STANDARD",
                                    phones = new[]
                                    {
                                        new
                                        {
                                            deviceType = "LANDLINE",
                                            countryCallingCode = "34",
                                            number = "480080071"
                                        },
                                        new
                                        {
                                            deviceType = "MOBILE",
                                            countryCallingCode = "33",
                                            number = "480080072"
                                        }
                                    },
                                    emailAddress = "support@increibleviajes.es",
                                    address = new
                                    {
                                        lines = new[] { "Calle Prado, 16" },
                                        postalCode = "28014",
                                        cityName = "Madrid",
                                        countryCode = "ES"
                                    }
                                }
                            }
                        }
                    }, Formatting.None,new JsonSerializerSettings{NullValueHandling = NullValueHandling.Ignore }));

                var r = amadeus.booking.flightOrder.getFlightOrderManagement(Params.with("Id",response.id));
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
            }
        }
    }
}

