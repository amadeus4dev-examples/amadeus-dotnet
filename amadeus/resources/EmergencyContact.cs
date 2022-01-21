using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An EmergencyContact object.
    /// </summary>
    public class EmergencyContact
    {
        internal EmergencyContact() { }

        /// <summary>
        /// Gets or sets the type of the addresseeName.
        /// </summary>
        /// <value>The type of the addresseeName.</value>
        public string addresseeName { get; set; }

        /// <summary>
        /// Gets or sets the type of the countryCode.
        /// </summary>
        /// <value>The type of the countryCode.</value>
        public string countryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the number.
        /// </summary>
        /// <value>The type of the number.</value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }
    }
}
