using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Fee object.
    /// </summary>
    public class Fee
    {
        internal Fee() { }

        /// <summary>
        /// Gets or sets the type of the amount.
        /// </summary>
        /// <value>The type of the amount.</value>
        public string amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the type.
        /// </summary>
        /// <value>The type of the type.</value>
        public string type { get; set; }

    }
}
