using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Itineraries object.
    /// </summary>
    public class Itineraries
    {
        internal Itineraries() { }

        /// <summary>
        /// Gets or sets the type of the duration.
        /// </summary>
        /// <value>The type of the duration.</value>
        public string duration { get; set; }

        /// <summary>
        /// Gets or sets the type of the segments.
        /// </summary>
        /// <value>The type of the segments.</value>
        public List<Segment> segments { get; set; }
    }
}
