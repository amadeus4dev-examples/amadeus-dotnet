using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Co2Emission object.
    /// </summary>
    public class Co2Emission
    {
        internal Co2Emission() { }

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

        /// <summary>
        /// Gets or sets the type of the cabin.
        /// </summary>
        /// <value>The type of the cabin.</value>
        public string cabin { get; set; }
    }
}
