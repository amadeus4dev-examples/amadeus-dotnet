using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightOfferPricingOutput object.
    /// </summary>
    public class FlightOfferPricingOutput : Resource
    {
        internal FlightOfferPricingOutput() { } 

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
        /// Gets or sets the type of the bookingRequirements.
        /// </summary>
        /// <value>The type of the bookingRequirements.</value>
        public BookingRequirements bookingRequirements { get; set; }
    }
}
