using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Aircraft object.
    /// </summary>
    public class Aircraft
    {
        internal Aircraft() { }

        /// <summary>
        /// Gets or sets the type of the aircraftType.
        /// </summary>
        /// <value>The type of the aircraftType.</value>
        public string aircraftType { get; set; }

        /// <summary>
        /// Gets or sets the type of the aircraftDescription.
        /// </summary>
        /// <value>The type of the aircraftDescription.</value>
        public string aircraftDescription { get; set; }
    }
}
