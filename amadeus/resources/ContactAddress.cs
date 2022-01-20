using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An ContactAddress object.
    /// </summary>
    public class ContactAddress
    {
        internal ContactAddress() { }

        /// <summary>
        /// Gets or sets the type of the lines.
        /// </summary>
        /// <value>The type of the lines.</value>
        public List<string> lines { get; set; }

        /// <summary>
        /// Gets or sets the type of the postalCode.
        /// </summary>
        /// <value>The type of the postalCode.</value>
        public string postalCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the countryCode.
        /// </summary>
        /// <value>The type of the countryCode.</value>
        public string countryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the cityName.
        /// </summary>
        /// <value>The type of the cityName.</value>
        public string cityName { get; set; }

        /// <summary>
        /// Gets or sets the type of the stateName.
        /// </summary>
        /// <value>The type of the stateName.</value>
        public string stateName { get; set; }

        /// <summary>
        /// Gets or sets the type of the postalBox.
        /// </summary>
        /// <value>The type of the postalBox.</value>
        public string postalBox { get; set; }
    }
}
