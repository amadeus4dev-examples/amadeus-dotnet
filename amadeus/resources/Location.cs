using System;
using resources.referenceData;

namespace amadeus.resources
{

    /// <summary>
    /// An Location object as returned by the Locaion API.
    /// <see cref="Locations.get()"/>
    /// </summary>
    public class Location : Resource
    {

        internal Location() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the sub.
        /// </summary>
        /// <value>The type of the sub.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the name of the detailed.
        /// </summary>
        /// <value>The name of the detailed.</value>
        public string detailedName { get; set; }

        /// <summary>
        /// Gets or sets the time zone offset.
        /// </summary>
        /// <value>The time zone offset.</value>
        public string timeZoneOffset { get; set; }

        /// <summary>
        /// Gets or sets the iata code.
        /// </summary>
        /// <value>The iata code.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the geo code.
        /// </summary>
        /// <value>The geo code.</value>
        public GeoCode geoCode { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public Address address { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>The distance.</value>
        public Distance distance { get; set; }

        /// <summary>
        /// Gets or sets the analytics.
        /// </summary>
        /// <value>The analytics.</value>
        public Analytics analytics { get; set; }

        /// <summary>
        /// Gets or sets the relevance.
        /// </summary>
        /// <value>The relevance.</value>
        public double relevance { get; set; }

        /// <summary>
        /// An Location-related object as returned by the Locaion API.
        /// <see cref="Locations.get()"/>
        /// </summary>
        public class GeoCode
        {

            internal GeoCode() { }

            /// <summary>
            /// Gets or sets the latitude.
            /// </summary>
            /// <value>The latitude.</value>
            public double latitude { get; set; }

            /// <summary>
            /// Gets or sets the longitude.
            /// </summary>
            /// <value>The longitude.</value>
            public double longitude { get; set; }

        }

        /// <summary>
        /// An Location-related object as returned by the Locaion API.
        /// <see cref="Locations.get()"/>
        /// </summary>
        public class Address
        {

            internal Address() { }

            /// <summary>
            /// Gets or sets the name of the city.
            /// </summary>
            /// <value>The name of the city.</value>
            public string cityName { get; set; }

            /// <summary>
            /// Gets or sets the city code.
            /// </summary>
            /// <value>The city code.</value>
            public string cityCode { get; set; }

            /// <summary>
            /// Gets or sets the name of the country.
            /// </summary>
            /// <value>The name of the country.</value>
            public string countryName { get; set; }

            /// <summary>
            /// Gets or sets the country code.
            /// </summary>
            /// <value>The country code.</value>
            public string countryCode { get; set; }

            /// <summary>
            /// Gets or sets the region code.
            /// </summary>
            /// <value>The region code.</value>
            public string regionCode { get; set; }

        }

        /// <summary>
        /// An Location-related object as returned by the Locaion API.
        /// <see cref="Locations.get()"/>
        /// </summary>
        public class Distance
        {

            internal Distance() { }

            /// <summary>
            /// Gets or sets the value.
            /// </summary>
            /// <value>The value.</value>
            public double value { get; set; }

            /// <summary>
            /// Gets or sets the unit.
            /// </summary>
            /// <value>The unit.</value>
            public string unit { get; set; }

        }

        /// <summary>
        /// An Location-related object as returned by the Locaion API.
        /// <see cref="Locations.get()"/>
        /// </summary>
        public class Analytics
        {

            internal Analytics() { }

            /// <summary>
            /// Gets or sets the flights.
            /// </summary>
            /// <value>The flights.</value>
            public Flights flights { get; set; }

            /// <summary>
            /// Gets or sets the travelers.
            /// </summary>
            /// <value>The travelers.</value>
            public Travelers travelers { get; set; }

        }

        /// <summary>
        /// An Location-related object as returned by the Locaion API.
        /// <see cref="Locations.get()"/>
        /// </summary>
        public class Flights
        {

            internal Flights() { }

            /// <summary>
            /// Gets or sets the score.
            /// </summary>
            /// <value>The score.</value>
            public double score { get; set; }

        }

        /// <summary>
        /// An Location-related object as returned by the Locaion API.
        /// <see cref="Locations.get()"/>
        /// </summary>
        public class Travelers
        {

            internal Travelers() { }

            /// <summary>
            /// Gets or sets the score.
            /// </summary>
            /// <value>The score.</value>
            public double score { get; set; }

        }

    }

}