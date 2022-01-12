using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightEndPoint object.
    /// </summary>
    public class FlightEndPoint
    {
        internal FlightEndPoint() { }

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

        /// <summary>
        /// Gets or sets the type of the at.
        /// </summary>
        /// <value>The type of the at.</value>
        public string at { get; set; }

    }
}
