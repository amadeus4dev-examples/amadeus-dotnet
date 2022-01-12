using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An LocationValue object.
    /// </summary>
    public class LocationValue
    {
        internal LocationValue() { }

        /// <summary>
        /// Gets or sets the type of the cityCode.
        /// </summary>
        /// <value>The type of the cityCode.</value>
        public string cityCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the countryCode.
        /// </summary>
        /// <value>The type of the countryCode.</value>
        public string countryCode { get; set; }
    }
}
