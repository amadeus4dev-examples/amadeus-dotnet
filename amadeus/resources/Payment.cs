using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Payment object.
    /// </summary>
    public class Payment
    {
        internal Payment() { }

        /// <summary>
        /// Gets or sets the type of the brand.
        /// </summary>
        /// <value>The type of the brand.</value>
        public string brand { get; set; }

        /// <summary>
        /// Gets or sets the type of the binNumber.
        /// </summary>
        /// <value>The type of the binNumber.</value>
        public int binNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOfferIds.
        /// </summary>
        /// <value>The type of the flightOfferIds.</value>
        public List<string> flightOfferIds { get; set; }
    }
}
