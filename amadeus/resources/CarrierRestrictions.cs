using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CarrierRestrictions object.
    /// </summary>
    public class CarrierRestrictions
    {
        public CarrierRestrictions() { }

        /// <summary>
        /// Gets or sets the type of the blacklistedInEUAllowed.
        /// </summary>
        /// <value>The type of the blacklistedInEUAllowed.</value>
        public bool blacklistedInEUAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the excludedCarrierCodes.
        /// </summary>
        /// <value>The type of the excludedCarrierCodes.</value>
        public List<string> excludedCarrierCodes { get; set; }

        /// <summary>
        /// Gets or sets the type of the includedCarrierCodes.
        /// </summary>
        /// <value>The type of the includedCarrierCodes.</value>
        public List<string> includedCarrierCodes { get; set; }
    }
}
