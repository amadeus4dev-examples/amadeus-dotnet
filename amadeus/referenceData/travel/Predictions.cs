using System;
using amadeus.travel.predictions;

namespace amadeus.referenceData
{

    /// <summary>
    /// 
    /// Predictions
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/travel/predictions</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.predictions;
    /// </code>
    /// 
    /// </summary>
    public class Predictions
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/predictions/trip-purpose</code> endpoints.
        /// </summary>
        public TripPurpose tripPurpose;

        /// <summary>
        /// Initializes a new instance of the Predictions class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Predictions(Amadeus client)
        {
            this.client = client;
            this.tripPurpose = new TripPurpose(client);

        }

    }

}
