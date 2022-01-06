using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Guests object.
    /// </summary>
    public class Guests
    {
        internal Guests() { }

        /// <summary>
        /// Gets or sets the adults.
        /// </summary>
        /// <value>The adults.</value>
        public int adults { get; set; }

        /// <summary>
        /// Gets or sets the childAge.
        /// </summary>
        /// <value>The childAge.</value>
        public int[] childAge { get; set; }
    }
}
