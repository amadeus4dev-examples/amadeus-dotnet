using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An SearchCriteriaLight object.
    /// </summary>
    public class SearchCriteriaLight
    {
        internal SearchCriteriaLight() { }

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
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public int doors { get; set; }
    }
}
