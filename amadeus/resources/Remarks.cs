using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Remarks object.
    /// </summary>
    public class Remarks
    {
        internal Remarks() { }

        /// <summary>
        /// Gets or sets the type of the general.
        /// </summary>
        /// <value>The type of the general.</value>
        public List<GeneralRemark> general { get; set; }

        /// <summary>
        /// Gets or sets the type of the airline.
        /// </summary>
        /// <value>The type of the airline.</value>
        public List<AirlineRemark> airline { get; set; }
    }
}
