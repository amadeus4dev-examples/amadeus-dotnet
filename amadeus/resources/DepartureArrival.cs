using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Departure object.
    /// </summary>
    public class DepartureArrival
    {
        internal DepartureArrival() { }

        /// <summary>
        /// Gets or sets the type of the subType.
        /// </summary>
        /// <value>The type of the subType.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the iataCode.
        /// </summary>
        /// <value>The type of the iataCode.</value>
        public string iataCode { get; set; }
    }
}
