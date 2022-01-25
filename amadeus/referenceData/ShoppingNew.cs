using System;
using amadeus.referenceData.flightOffers;
using amadeus.shopping;

namespace amadeus.referenceData
{

    /// <summary>
    /// 
    /// Shopping
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/shopping</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping;
    /// </code>
    /// 
    /// </summary>
    public class ShoppingNew
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flight-offers</code> endpoints.
        /// </summary>
        public FlightOffersSearch flightOffersSearch;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/seatmaps</code> endpoints.
        /// </summary>
        public SeatMapDisplay seatMapDisplay;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flightOffers</code> endpoints.
        /// </summary>
        public FlightOffersNew flightOffers;

        /// <summary>
        /// Initializes a new instance of the Shopping class.
        /// </summary>
        /// <param name="client">Client.</param>
        public ShoppingNew(Amadeus client)
        {
            this.client = client;
            this.flightOffersSearch = new FlightOffersSearch(client);
            this.seatMapDisplay = new SeatMapDisplay(client);
            this.flightOffers = new FlightOffersNew(client);

        }

    }

}
