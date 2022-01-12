using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Area object.
    /// </summary>
    public class Area
    {
        internal Area() { }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the iataCode.
        /// </summary>
        /// <value>The type of the iataCode.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the iataCode.
        /// </summary>
        /// <value>The type of the iataCode.</value>
        public GeoCode geoCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the areaType.
        /// </summary>
        /// <value>The type of the areaType.</value>
        public string areaType { get; set; }
    }
}
