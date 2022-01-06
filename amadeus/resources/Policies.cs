using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Policies object.
    /// </summary>
    public class Policies
    {
        internal Policies() { }

        /// <summary>
        /// Gets or sets the cancellation.
        /// </summary>
        /// <value>The cancellation.</value>
        public Cancellation cancellation { get; set; }
    }
}
