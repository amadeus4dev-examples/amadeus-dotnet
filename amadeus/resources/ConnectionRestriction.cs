using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An ConnectionRestriction object.
    /// </summary>
    public class ConnectionRestriction
    {
        internal ConnectionRestriction() { }

        /// <summary>
        /// Gets or sets the type of the maxNumberOfConnections.
        /// </summary>
        /// <value>The type of the maxNumberOfConnections.</value>
        public int maxNumberOfConnections { get; set; }

        /// <summary>
        /// Gets or sets the type of the airportChangeAllowed.
        /// </summary>
        /// <value>The type of the airportChangeAllowed.</value>
        public bool airportChangeAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the technicalStopsAllowed.
        /// </summary>
        /// <value>The type of the technicalStopsAllowed.</value>
        public bool technicalStopsAllowed { get; set; }
    }
}
