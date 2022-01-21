using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CreditCardCommon object.
    /// </summary>
    public class CreditCardCommon
    {
        internal CreditCardCommon() { }

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
        /// Gets or sets the type of the amount.
        /// </summary>
        /// <value>The type of the amount.</value>
        public string amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the currencyCode.
        /// </summary>
        /// <value>The type of the currencyCode.</value>
        public string currencyCode { get; set; }
    }
}
