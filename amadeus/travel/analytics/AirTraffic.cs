using System;

namespace amadeus.travel.analytics.airTraffic
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/analytics/air-traffic</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.analytics.airTraffic;
    /// </code>
    /// </summary>
    public class AirTraffic
    {

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/analytics/air-traffic/searched</code> endpoints.
        /// </summary>
        /// <value>The searched.</value>
        public Searched searched { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/analytics/air-traffic/searched/by-destination</code> endpoints.
        /// </summary>
        /// <value>The searched by destination.</value>
        public SearchedByDestination searchedByDestination { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/analytics/air-traffic/traveled</code> endpoints.
        /// </summary>
        /// <value>The traveled.</value>
        public Traveled traveled { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/analytics/air-traffic/booked</code> endpoints.
        /// </summary>
        /// <value>The booked.</value>
        public Booked booked { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/analytics/air-traffic/busiest-period</code> endpoints.
        /// </summary>
        /// <value>The busiest period.</value>
        public BusiestPeriod busiestPeriod { get; set; }

        /// <summary>
        /// Initializes a new instance of the AirTraffic class.
        /// </summary>
        /// <param name="client">Client.</param>
        public AirTraffic(Amadeus client)
        {
            this.searched = new Searched(client);
            this.searchedByDestination = new SearchedByDestination(client);
            this.traveled = new Traveled(client);
            this.booked = new Booked(client);
            this.busiestPeriod = new BusiestPeriod(client);
        }

    }

}