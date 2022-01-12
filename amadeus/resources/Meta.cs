using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Meta object.
    /// </summary>
    public class Meta
    {
        internal Meta() { }

        /// <summary>
        /// Gets or sets the type of the links.
        /// </summary>
        /// <value>The type of the links.</value>
        public Link links { get; set; }

        /// <summary>
        /// Gets or sets the type of the lang.
        /// </summary>
        /// <value>The type of the lang.</value>
        public string lang { get; set; }
    }
}
