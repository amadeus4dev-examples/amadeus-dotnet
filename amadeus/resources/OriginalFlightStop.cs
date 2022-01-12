using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An OriginalFlightStop object.
    /// </summary>
    public class OriginalFlightStop
    {
        internal OriginalFlightStop() { }

        /// <summary>
        /// Gets or sets the type of the iataCode.
        /// </summary>
        /// <value>The type of the iataCode.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the duration.
        /// </summary>
        /// <value>The type of the duration.</value>
        public string duration { get; set; }

    }
}
