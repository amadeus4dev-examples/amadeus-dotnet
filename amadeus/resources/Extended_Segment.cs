using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Extended_Segment object.
    /// </summary>
    public class Extended_Segment
    {
        internal Extended_Segment() { }

        /// <summary>
        /// Gets or sets the type of the closedStatus.
        /// </summary>
        /// <value>The type of the closedStatus.</value>
        public string closedStatus { get; set; }

        /// <summary>
        /// Gets or sets the type of the availabilityClasses.
        /// </summary>
        /// <value>The type of the availabilityClasses.</value>
        public List<AvailabilityClass> availabilityClasses { get; set; }

        /// <summary>
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public int doors { get; set; }
    }
}
