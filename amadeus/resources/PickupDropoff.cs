using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Pickup object.
    /// </summary>
    public class PickupDropoff
    {
        internal PickupDropoff() { }

        /// <summary>
        /// Gets or sets the type of the localDateTime.
        /// </summary>
        /// <value>The type of the localDateTime.</value>
        public string localDateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the location.
        /// </summary>
        /// <value>The type of the location.</value>
        public Location location { get; set; }
    }
}
