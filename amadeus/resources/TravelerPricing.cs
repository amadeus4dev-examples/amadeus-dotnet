using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TravelerPricing object.
    /// </summary>
    public class TravelerPricing
    {
        internal TravelerPricing() { }

        /// <summary>
        /// Gets or sets the type of the travelerId.
        /// </summary>
        /// <value>The type of the travelerId.</value>
        public string travelerId { get; set; }

        /// <summary>
        /// Gets or sets the type of the fareOption.
        /// </summary>
        /// <value>The type of the fareOption.</value>
        public string fareOption { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerType.
        /// </summary>
        /// <value>The type of the travelerType.</value>
        public string travelerType { get; set; }

        /// <summary>
        /// Gets or sets the type of the associatedAdultId.
        /// </summary>
        /// <value>The type of the associatedAdultId.</value>
        public string associatedAdultId { get; set; }

        /// <summary>
        /// Gets or sets the type of the price.
        /// </summary>
        /// <value>The type of the price.</value>
        public Price price { get; set; }

        /// <summary>
        /// Gets or sets the type of the fareDetailsBySegment.
        /// </summary>
        /// <value>The type of the fareDetailsBySegment.</value>
        public List<FareDetailsBySegment> fareDetailsBySegment { get; set; }
    }
}
