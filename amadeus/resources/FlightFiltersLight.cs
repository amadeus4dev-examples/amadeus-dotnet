using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightFiltersLight object.
    /// </summary>
    public class FlightFiltersLight
    {
        internal FlightFiltersLight() { }

        /// <summary>
        /// Gets or sets the type of the carrierRestrictions.
        /// </summary>
        /// <value>The type of the carrierRestrictions.</value>
        public CarrierRestrictions carrierRestrictions { get; set; }

        /// <summary>
        /// Gets or sets the type of the cabinRestrictions.
        /// </summary>
        /// <value>The type of the cabinRestrictions.</value>
        public List<CabinRestriction> cabinRestrictions { get; set; }

        /// <summary>
        /// Gets or sets the type of the connectionRestriction.
        /// </summary>
        /// <value>The type of the connectionRestriction.</value>
        public ConnectionRestriction connectionRestriction { get; set; }
    }
}
