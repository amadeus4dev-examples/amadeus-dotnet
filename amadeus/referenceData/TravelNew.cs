using System;

namespace amadeus.referenceData
{

    /// <summary>
    /// 
    /// Travel
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/travel</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel;
    /// </code>
    /// 
    /// </summary>
    public class TravelNew
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/travel/predictions</code> endpoints.
        /// </summary>
        public Predictions predictions;

        /// <summary>
        /// Initializes a new instance of the Travel class.
        /// </summary>
        /// <param name="client">Client.</param>
        public TravelNew(Amadeus client)
        {
            this.client = client;
            this.predictions = new Predictions(client);

        }

    }

}
