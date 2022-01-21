using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CreditCard object.
    /// </summary>
    public class CreditCard
    {
        internal CreditCard() { }

        /// <summary>
        /// Gets or sets the type of the brand.
        /// </summary>
        /// <value>The type of the brand.</value>
        public string brand { get; set; }

        /// <summary>
        /// Gets or sets the type of the holder.
        /// </summary>
        /// <value>The type of the holder.</value>
        public string holder { get; set; }

        /// <summary>
        /// Gets or sets the type of the number.
        /// </summary>
        /// <value>The type of the number.</value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the type of the expiryDate.
        /// </summary>
        /// <value>The type of the expiryDate.</value>
        public string expiryDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the securityCode.
        /// </summary>
        /// <value>The type of the securityCode.</value>
        public string securityCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the method.
        /// </summary>
        /// <value>The type of the method.</value>
        public string method { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOfferIds.
        /// </summary>
        /// <value>The type of the flightOfferIds.</value>
        public List<string> flightOfferIds { get; set; }
    }
}
