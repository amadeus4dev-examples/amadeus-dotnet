using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AdditionalInformation object.
    /// </summary>
    public class AdditionalInformation
    {
        internal AdditionalInformation() { }

        /// <summary>
        /// Gets or sets the type of the chargeableCheckedBags.
        /// </summary>
        /// <value>The type of the chargeableCheckedBags.</value>
        public bool chargeableCheckedBags { get; set; }

        /// <summary>
        /// Gets or sets the type of the brandedFares.
        /// </summary>
        /// <value>The type of the brandedFares.</value>
        public bool brandedFares { get; set; }

    }
}
