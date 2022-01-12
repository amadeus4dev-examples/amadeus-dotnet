using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Extended_OriginDestinationLight object.
    /// </summary>
    public class Extended_OriginDestinationLight
    {
        internal Extended_OriginDestinationLight() { }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the originLocationCode.
        /// </summary>
        /// <value>The type of the originLocationCode.</value>
        public string originLocationCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the destinationLocationCode.
        /// </summary>
        /// <value>The type of the destinationLocationCode.</value>
        public string destinationLocationCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the includedConnectionPoints.
        /// </summary>
        /// <value>The type of the includedConnectionPoints.</value>
        public List<ConnectionPoints> includedConnectionPoints { get; set; }

        /// <summary>
        /// Gets or sets the type of the excludedConnectionPoints.
        /// </summary>
        /// <value>The type of the excludedConnectionPoints.</value>
        public List<ConnectionPoints> excludedConnectionPoints { get; set; }

        /// <summary>
        /// Gets or sets the type of the departureDateTime.
        /// </summary>
        /// <value>The type of the departureDateTime.</value>
        public FlightDateTime departureDateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrivalDateTime.
        /// </summary>
        /// <value>The type of the arrivalDateTime.</value>
        public FlightDateTime arrivalDateTime { get; set; }
    }
}
