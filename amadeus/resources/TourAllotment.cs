using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TourAllotment object.
    /// </summary>
    public class TourAllotment
    {
        internal TourAllotment() { }

        /// <summary>
        /// Gets or sets the type of the tourName.
        /// </summary>
        /// <value>The type of the tourName.</value>
        public string tourName { get; set; }

        /// <summary>
        /// Gets or sets the type of the tourReference.
        /// </summary>
        /// <value>The type of the tourReference.</value>
        public string tourReference { get; set; }

        /// <summary>
        /// Gets or sets the type of the mode.
        /// </summary>
        /// <value>The type of the mode.</value>
        public string mode { get; set; }

        /// <summary>
        /// Gets or sets the type of the remainingSeats.
        /// </summary>
        /// <value>The type of the remainingSeats.</value>
        public string remainingSeats { get; set; }
    }
}
