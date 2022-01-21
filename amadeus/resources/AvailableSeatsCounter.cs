using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AvailableSeatsCounter object.
    /// </summary>
    public class AvailableSeatsCounter
    {
        internal AvailableSeatsCounter() { }

        /// <summary>
        /// Gets or sets the type of the travelerId.
        /// </summary>
        /// <value>The type of the travelerId.</value>
        public string travelerId { get; set; }

        /// <summary>
        /// Gets or sets the type of the value.
        /// </summary>
        /// <value>The type of the value.</value>
        public int value { get; set; }
    }
}
