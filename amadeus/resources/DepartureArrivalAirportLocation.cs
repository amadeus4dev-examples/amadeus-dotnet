using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DepartureArrivalAirportLocation object.
    /// </summary>
    public class DepartureArrivalAirportLocation
    {
        internal DepartureArrivalAirportLocation() { }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the address.
        /// </summary>
        /// <value>The type of the address.</value>
        public Address address { get; set; }
    }
}
