using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An MarketingOperating object.
    /// </summary>
    public class MarketingOperating
    {
        internal MarketingOperating() { }

        /// <summary>
        /// Gets or sets the type of the carrier.
        /// </summary>
        /// <value>The type of the carrier.</value>
        public Carrier carrier { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightDesignator.
        /// </summary>
        /// <value>The type of the flightDesignator.</value>
        public FlightDesignator flightDesignator { get; set; }
    }
}
