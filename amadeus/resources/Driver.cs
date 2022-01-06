using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Driver object.
    /// </summary>
    public class Driver
    {
        internal Driver() { }

        /// <summary>
        /// Gets or sets the type of the contacts.
        /// </summary>
        /// <value>The type of the contacts.</value>
        public Contact[] contacts { get; set; }
    }
}
