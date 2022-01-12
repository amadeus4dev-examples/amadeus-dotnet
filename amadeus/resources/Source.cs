using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Source object.
    /// </summary>
    public class Source
    {
        internal Source() { }

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
        public bool includeClosedContent { get; set; }

        /// <summary>
        /// Gets or sets the type of the bookingClass.
        /// </summary>
        /// <value>The type of the bookingClass.</value>
        public string bookingClass { get; set; }
    }
}
