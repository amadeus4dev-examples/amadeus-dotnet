using System;
using System.Collections.Generic;
using amadeus.resources;
using amadeus.shopping;

namespace amadeus.resources
{

    /// <summary>
    /// An FlightOffer object as returned by the FlightOffers API.
    /// <see cref="FlightOffers.get()"/>
    /// </summary>
    public class FlightOffer : Resource
    {

        internal FlightOffer() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>The source.</value>
        public string source { get; set; }

        /// <summary>
        /// Gets or sets the instantTicketingRequired.
        /// </summary>
        /// <value>The instantTicketingRequired.</value>
        public bool instantTicketingRequired { get; set; }

        /// <summary>
        /// Gets or sets the disablePricing.
        /// </summary>
        /// <value>The disablePricing.</value>
        public bool disablePricing { get; set; }

        /// <summary>
        /// Gets or sets the nonHomogeneous.
        /// </summary>
        /// <value>The nonHomogeneous.</value>
        public bool nonHomogeneous { get; set; }

        /// <summary>
        /// Gets or sets the oneWay.
        /// </summary>
        /// <value>The oneWay.</value>
        public bool oneWay { get; set; }

        /// <summary>
        /// Gets or sets the paymentCardRequired.
        /// </summary>
        /// <value>The paymentCardRequired.</value>
        public bool paymentCardRequired { get; set; }

        /// <summary>
        /// Gets or sets the lastTicketingDate.
        /// </summary>
        /// <value>The lastTicketingDate.</value>
        public string lastTicketingDate { get; set; }

        /// <summary>
        /// Gets or sets the numberOfBookableSeats.
        /// </summary>
        /// <value>The numberOfBookableSeats.</value>
        public int numberOfBookableSeats { get; set; }

        /// <summary>
        /// Gets or sets the itineraries.
        /// </summary>
        /// <value>The itineraries.</value>
        public List<Itineraries> itineraries { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public Price price { get; set; }

        /// <summary>
        /// Gets or sets the pricingOptions.
        /// </summary>
        /// <value>The pricingOptions.</value>
        public PricingOptions pricingOptions { get; set; }

        /// <summary>
        /// Gets or sets the validatingAirlineCodes.
        /// </summary>
        /// <value>The validatingAirlineCodes.</value>
        public List<string> validatingAirlineCodes { get; set; }

        /// <summary>
        /// Gets or sets the travelerPricings.
        /// </summary>
        /// <value>The travelerPricings.</value>
        public List<TravelerPricing> travelerPricings { get; set; }
    }

}
