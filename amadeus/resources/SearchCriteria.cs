using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An SearchCriteria object.
    /// </summary>
    public class SearchCriteria
    {
        public SearchCriteria() { }

        /// <summary>
        /// Gets or sets the type of the excludeAllotments.
        /// </summary>
        /// <value>The type of the excludeAllotments.</value>
        public bool excludeAllotments { get; set; }

        /// <summary>
        /// Gets or sets the type of the addOneWayOffers.
        /// </summary>
        /// <value>The type of the addOneWayOffers.</value>
        public bool addOneWayOffers { get; set; }

        /// <summary>
        /// Gets or sets the type of the maxFlightOffers.
        /// </summary>
        /// <value>The type of the maxFlightOffers.</value>
        public int maxFlightOffers { get; set; }

        /// <summary>
        /// Gets or sets the type of the maxPrice.
        /// </summary>
        /// <value>The type of the maxPrice.</value>
        public int maxPrice { get; set; }

        /// <summary>
        /// Gets or sets the type of the allowAlternativeFareOptions.
        /// </summary>
        /// <value>The type of the allowAlternativeFareOptions.</value>
        public bool allowAlternativeFareOptions { get; set; }

        /// <summary>
        /// Gets or sets the type of the oneFlightOfferPerDay.
        /// </summary>
        /// <value>The type of the oneFlightOfferPerDay.</value>
        public bool oneFlightOfferPerDay { get; set; }

        /// <summary>
        /// Gets or sets the type of the additionalInformation.
        /// </summary>
        /// <value>The type of the additionalInformation.</value>
        public AdditionalInformation additionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the type of the pricingOptions.
        /// </summary>
        /// <value>The type of the pricingOptions.</value>
        public PricingOptions pricingOptions { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightFilters.
        /// </summary>
        /// <value>The type of the flightFilters.</value>
        public FlightFilters flightFilters { get; set; }


    }
}
