using System;
using amadeus.travel;
namespace amadeus
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/travel</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel;
    /// </code>
    /// </summary>
    public class Travel
    {
        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/travel/analytics</code> endpoints.
        /// </summary>
        public Analytics analytics;

        /// <summary>
        /// Initializes a new instance of the Travel class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Travel(Amadeus client)
        {
            this.analytics = new Analytics(client);
        }

    }
}
