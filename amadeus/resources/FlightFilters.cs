using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightFilters object.
    /// </summary>
    public class FlightFilters
    {
        public FlightFilters() { }

        /// <summary>
        /// Gets or sets the type of the crossBorderAllowed.
        /// </summary>
        /// <value>The type of the crossBorderAllowed.</value>
        public bool crossBorderAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the moreOvernightsAllowed.
        /// </summary>
        /// <value>The type of the moreOvernightsAllowed.</value>
        public bool moreOvernightsAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the returnToDepartureAirport.
        /// </summary>
        /// <value>The type of the returnToDepartureAirport.</value>
        public bool returnToDepartureAirport { get; set; }

        /// <summary>
        /// Gets or sets the type of the railSegmentAllowed.
        /// </summary>
        /// <value>The type of the railSegmentAllowed.</value>
        public bool railSegmentAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the busSegmentAllowed.
        /// </summary>
        /// <value>The type of the busSegmentAllowed.</value>
        public bool busSegmentAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the maxFlightTime.
        /// </summary>
        /// <value>The type of the maxFlightTime.</value>
        public int maxFlightTime { get; set; }

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
