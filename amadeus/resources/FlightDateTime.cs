using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightDateTime object.
    /// </summary>
    public class FlightDateTime
    {
        internal FlightDateTime() { }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the time.
        /// </summary>
        /// <value>The type of the time.</value>
        public string time { get; set; }

    }
}
