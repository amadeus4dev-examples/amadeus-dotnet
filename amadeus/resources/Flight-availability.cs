using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightAvailability object.
    /// </summary>
    public class FlightAvailability
    {
        internal FlightAvailability() { }

        /// <summary>
        /// Gets or sets the type of the type.
        /// </summary>
        /// <value>The type of the type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the originDestinationId.
        /// </summary>
        /// <value>The type of the originDestinationId.</value>
        public string originDestinationId { get; set; }

        /// <summary>
        /// Gets or sets the type of the source.
        /// </summary>
        /// <value>The type of the source.</value>
        public string source { get; set; }

        /// <summary>
        /// Gets or sets the type of the instantTicketingRequired.
        /// </summary>
        /// <value>The type of the instantTicketingRequired.</value>
        public bool instantTicketingRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the paymentCardRequired.
        /// </summary>
        /// <value>The type of the paymentCardRequired.</value>
        public bool paymentCardRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the duration.
        /// </summary>
        /// <value>The type of the duration.</value>
        public string duration { get; set; }

        /// <summary>
        /// Gets or sets the type of the segments.
        /// </summary>
        /// <value>The type of the segments.</value>
        public List<Extended_Segment> segments { get; set; }
    }
}
