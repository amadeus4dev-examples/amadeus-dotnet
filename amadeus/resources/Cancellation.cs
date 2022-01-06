using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Cancellation object.
    /// </summary>
    public class Cancellation
    {
        internal Cancellation() { }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public Description description { get; set; }
    }
}
