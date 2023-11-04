using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CarVePricingOptionshicle object.
    /// </summary>
    public class PricingOptions
    {
        internal PricingOptions() { }
        public List<string> fareType { get; set; }
        /// <summary>
        /// Gets or sets the type of the includedCheckedBagsOnly.
        /// </summary>
        /// <value>The type of the includedCheckedBagsOnly.</value>
        public bool includedCheckedBagsOnly { get; set; }

        /// <summary>
        /// Gets or sets the type of the refundableFare.
        /// </summary>
        /// <value>The type of the refundableFare.</value>
        public bool refundableFare { get; set; }

        /// <summary>
        /// Gets or sets the type of the noRestrictionFare.
        /// </summary>
        /// <value>The type of the noRestrictionFare.</value>
        public bool noRestrictionFare { get; set; }

        /// <summary>
        /// Gets or sets the type of the noPenaltyFare.
        /// </summary>
        /// <value>The type of the noPenaltyFare.</value>
        public bool noPenaltyFare { get; set; }
    }
}
