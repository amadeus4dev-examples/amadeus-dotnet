using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An ContactPhone object.
    /// </summary>
    public class ContactPhone
    {
        internal ContactPhone() { }

        /// <summary>
        /// Gets or sets the type of the deviceType.
        /// </summary>
        /// <value>The type of the deviceType.</value>
        public string deviceType { get; set; }

        /// <summary>
        /// Gets or sets the type of the countryCallingCode.
        /// </summary>
        /// <value>The type of the countryCallingCode.</value>
        public string countryCallingCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the number.
        /// </summary>
        /// <value>The type of the number.</value>
        public string number { get; set; }
    }
}
