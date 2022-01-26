using System;
using amadeus.safety;

namespace amadeus
{

    /// <summary>
    /// 
    /// Shopping
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/safety</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.safety;
    /// </code>
    /// 
    /// </summary>
    public class Safety
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/safety/safety-rated-locations</code> endpoints.
        /// </summary>
        public SafePlace safePlace;

        /// <summary>
        /// Initializes a new instance of the Safety class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Safety(Amadeus client)
        {
            this.client = client;
            this.safePlace = new SafePlace(client);

        }

    }

}
