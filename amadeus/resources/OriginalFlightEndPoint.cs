using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An OriginalFlightEndPoint object.
    /// </summary>
    public class OriginalFlightEndPoint
    {
        internal OriginalFlightEndPoint() { }

        /// <summary>
        /// Gets or sets the type of the iataCode.
        /// </summary>
        /// <value>The type of the iataCode.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the terminal.
        /// </summary>
        /// <value>The type of the terminal.</value>
        public string terminal { get; set; }

    }
}
