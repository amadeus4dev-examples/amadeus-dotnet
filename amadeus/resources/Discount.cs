using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Discount object.
    /// </summary>
    public class Discount
    {
        internal Discount() { }

        /// <summary>
        /// Gets or sets the type of the subType.
        /// </summary>
        /// <value>The type of the subType.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the type of the cityName.
        /// </summary>
        /// <value>The type of the cityName.</value>
        public string cityName { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerType.
        /// </summary>
        /// <value>The type of the travelerType.</value>
        public string travelerType { get; set; }

        /// <summary>
        /// Gets or sets the type of the cardNumber.
        /// </summary>
        /// <value>The type of the cardNumber.</value>
        public string cardNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the certificateNumber.
        /// </summary>
        /// <value>The type of the certificateNumber.</value>
        public string certificateNumber { get; set; }
    }
}
