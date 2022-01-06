using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Baggage object.
    /// </summary>
    public class Baggage
    {
        internal Baggage() { }

        /// <summary>
        /// Gets or sets the type of the quantity.
        /// </summary>
        /// <value>The type of the quantity.</value>
        public string quantity { get; set; }

        /// <summary>
        /// Gets or sets the type of the weight.
        /// </summary>
        /// <value>The type of the weight.</value>
        public Weight weight { get; set; }
    }
}
