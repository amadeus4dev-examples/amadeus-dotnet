using System;
using amadeus.travel.analytics.airTraffic;

namespace amadeus.travel
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/analytics</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.analytics;
    /// </code>
    /// </summary>
    public class Analytics
    {

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/analytics/air-traffics</code> endpoints.
        /// </summary>
        /// <value>The air traffic.</value>
        public AirTraffic airTraffic { get; set; }

        /// <summary>
        /// Initializes a new instance of the Analytics class.
        /// </summary>
        /// <param name="client">Client.</param>
        internal Analytics(Amadeus client) 
        {
            this.airTraffic = new AirTraffic(client);
        }

    }

}