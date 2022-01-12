using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Extended_SearchCriteria object.
    /// </summary>
    public class Extended_SearchCriteria
    {
        internal Extended_SearchCriteria() { }

        /// <summary>
        /// Gets or sets the type of the excludeAllotments.
        /// </summary>
        /// <value>The type of the excludeAllotments.</value>
        public bool excludeAllotments { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightFilters.
        /// </summary>
        /// <value>The type of the flightFilters.</value>
        public FlightFiltersLight flightFilters { get; set; }

        /// <summary>
        /// Gets or sets the type of the includeClosedContent.
        /// </summary>
        /// <value>The type of the includeClosedContent.</value>
        public string includeClosedContent { get; set; }

        /// <summary>
        /// Gets or sets the type of the class.
        /// </summary>
        /// <value>The type of the class.</value>
        public string bookedClass { get; set; }
    }
}
