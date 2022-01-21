using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An SeatmapTravelerPricing object.
    /// </summary>
    public class SeatmapTravelerPricing
    {
        internal SeatmapTravelerPricing() { }

        /// <summary>
        /// Gets or sets the type of the travelerId.
        /// </summary>
        /// <value>The type of the travelerId.</value>
        public string travelerId { get; set; }

        /// <summary>
        /// Gets or sets the type of the seatAvailabilityStatus.
        /// </summary>
        /// <value>The type of the seatAvailabilityStatus.</value>
        public string seatAvailabilityStatus { get; set; }

        /// <summary>
        /// Gets or sets the type of the price.
        /// </summary>
        /// <value>The type of the price.</value>
        public Price price { get; set; }
    }
}
