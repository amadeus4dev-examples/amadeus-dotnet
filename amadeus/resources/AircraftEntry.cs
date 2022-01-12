using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AircraftEntry object.
    /// </summary>
    public class AircraftEntry
    {
        internal AircraftEntry() { }

        /// <summary>
        /// Gets or sets the type of the key.
        /// </summary>
        /// <value>The type of the key.</value>
        public string key { get; set; }

        /// <summary>
        /// Gets or sets the type of the model .
        /// </summary>
        /// <value>The type of the model .</value>
        public string model { get; set; }

    }
}
