using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AdditionalServicesRequest object.
    /// </summary>
    public class AdditionalServicesRequest
    {
        internal AdditionalServicesRequest() { }

        /// <summary>
        /// Gets or sets the type of the chargeableCheckedBags.
        /// </summary>
        /// <value>The type of the chargeableCheckedBags.</value>
        public BaggageAllowance chargeableCheckedBags { get; set; }

        /// <summary>
        /// Gets or sets the type of the chargeableSeatNumber.
        /// </summary>
        /// <value>The type of the chargeableSeatNumber.</value>
        public string chargeableSeatNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the otherServices.
        /// </summary>
        /// <value>The type of the otherServices.</value>
        public List<string> otherServices { get; set; }
    }
}
