using System;
using amadeus.resources;

namespace amadeus.resources
{


    /// <summary>
    /// An Airline object as returned by the Airline Code LookUp API.
    /// <see cref="ReferenceData.airlines"/>
    /// </summary>
    public class Airline : Resource
    {

        internal Airline() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the iata code.
        /// </summary>
        /// <value>The iata code.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the icao code.
        /// </summary>
        /// <value>The icao code.</value>
        public string icaoCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the business.
        /// </summary>
        /// <value>The name of the business.</value>
        public string businessName { get; set; }

        /// <summary>
        /// Gets or sets the name of the common.
        /// </summary>
        /// <value>The name of the common.</value>
        public string commonName { get; set; }

    }

}
