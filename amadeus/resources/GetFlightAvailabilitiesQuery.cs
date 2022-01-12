using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An GetFlightAvailabilitiesQuery object.
    /// </summary>
    public class GetFlightAvailabilitiesQuery
    {
        internal GetFlightAvailabilitiesQuery() { }

        /// <summary>
        /// Gets or sets the type of the originDestinations.
        /// </summary>
        /// <value>The type of the originDestinations.</value>
        public List<Extended_OriginDestinationLight> originDestinations { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelers.
        /// </summary>
        /// <value>The type of the travelers.</value>
        public List<TravelerInfo> travelers { get; set; }

        /// <summary>
        /// Gets or sets the type of the sources.
        /// </summary>
        /// <value>The type of the sources.</value>
        public List<Source> sources { get; set; }

        /// <summary>
        /// Gets or sets the type of the searchCriteria.
        /// </summary>
        /// <value>The type of the searchCriteria.</value>
        public Extended_SearchCriteria searchCriteria { get; set; }
    }
}
