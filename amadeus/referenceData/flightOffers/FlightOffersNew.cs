using System;
using amadeus.shopping.flightOffers;

namespace amadeus.referenceData.flightOffers
{

    /// <summary>
    /// 
    /// FlightOffers
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/shopping/flightOffers</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping.flightOffers;
    /// </code>
    /// 
    /// </summary>
    public class FlightOffersNew
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flight-offers/pricing</code> endpoints.
        /// </summary>
        public FlightOffersPricing flightOffersPricing;

        /// <summary>
        /// Initializes a new instance of the FlightOffers class.
        /// </summary>
        /// <param name="client">Client.</param>
        public FlightOffersNew(Amadeus client)
        {
            this.client = client;
            this.flightOffersPricing = new FlightOffersPricing(client);
        }

    }

}
