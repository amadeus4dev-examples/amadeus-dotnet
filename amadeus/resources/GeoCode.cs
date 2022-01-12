using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An GeoCode object.
    /// </summary>
    public class GeoCode
    {
        internal GeoCode() { }

        /// <summary>
        /// Gets or sets the type of the latitude.
        /// </summary>
        /// <value>The type of the latitude.</value>
        public string latitude { get; set; }

        /// <summary>
        /// Gets or sets the type of the longitude.
        /// </summary>
        /// <value>The type of the longitude.</value>
        public string longitude { get; set; }

    }
}
