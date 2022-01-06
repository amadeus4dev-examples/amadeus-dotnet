using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Price object.
    /// </summary>
    public class Price
    {
        internal Price() { }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currency { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        public string total { get; set; }

        /// <summary>
        /// Gets or sets the base.
        /// </summary>
        /// <value>The base.</value>
        public string Base { get; set; }

        /// <summary>
        /// Gets or sets the totalTaxes.
        /// </summary>
        /// <value>The totalTaxes.</value>
        public string totalTaxes { get; set; }
    }
}
