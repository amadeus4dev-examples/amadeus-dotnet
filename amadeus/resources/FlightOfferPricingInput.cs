using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CarVehicle object.
    /// </summary>
    public class FlightOfferPricingInput
    {
        public FlightOfferPricingInput() { }

        /// <summary>
        /// Gets or sets the type of the type.
        /// </summary>
        /// <value>The type of the type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOffers.
        /// </summary>
        /// <value>The type of the flightOffers.</value>
        public List<FlightOffer> flightOffers { get; set; }

        /// <summary>
        /// Gets or sets the type of the payments.
        /// </summary>
        /// <value>The type of the payments.</value>
        public List<Payment> payments { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelers.
        /// </summary>
        /// <value>The type of the travelers.</value>
        public List<TravelerElement> travelers { get; set; }
    }
}
