using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An BaggageAllowance object.
    /// </summary>
    public class BaggageAllowance
    {
        internal BaggageAllowance() { }

        /// <summary>
        /// Gets or sets the type of the quantity.
        /// </summary>
        /// <value>The type of the quantity.</value>
        public int quantity { get; set; }

        /// <summary>
        /// Gets or sets the type of the weight.
        /// </summary>
        /// <value>The type of the weight.</value>
        public int weight { get; set; }

        /// <summary>
        /// Gets or sets the type of the weightUnit.
        /// </summary>
        /// <value>The type of the weightUnit.</value>
        public string weightUnit { get; set; }
    }
}
