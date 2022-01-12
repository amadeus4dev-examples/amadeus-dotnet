using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Dictionaries object.
    /// </summary>
    public class Dictionaries
    {
        internal Dictionaries() { }

        /// <summary>
        /// Gets or sets the type of the locations.
        /// </summary>
        /// <value>The type of the locations.</value>
        public LocationEntry locations { get; set; }

        /// <summary>
        /// Gets or sets the type of the aircraft.
        /// </summary>
        /// <value>The type of the aircraft.</value>
        public AircraftEntry aircraft { get; set; }

        /// <summary>
        /// Gets or sets the type of the currencies.
        /// </summary>
        /// <value>The type of the currencies.</value>
        public CurrencyEntry currencies { get; set; }

        /// <summary>
        /// Gets or sets the type of the currencies.
        /// </summary>
        /// <value>The type of the currencies.</value>
        public CarrierEntry carriers { get; set; }
    }
}
