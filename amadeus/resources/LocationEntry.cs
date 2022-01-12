using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An LocationEntry object.
    /// </summary>
    public class LocationEntry
    {
        internal LocationEntry() { }

        /// <summary>
        /// Gets or sets the type of the key.
        /// </summary>
        /// <value>The type of the key.</value>
        public string key { get; set; }

        /// <summary>
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public LocationValue locationValue { get; set; }
    }
}
