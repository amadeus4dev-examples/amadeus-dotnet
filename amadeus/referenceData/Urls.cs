using amadeus;
using resources.referenceData.urls;

namespace resources.referenceData
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/reference-data/urls</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.referenceData.urls;
    /// </code>
    /// </summary>
    public class Urls
    {

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/urls/checkin-links</code> endpoints.
        /// </summary>
        /// <value>The checkin links.</value>
        public CheckinLinks checkinLinks { get; set; }

        /// <summary>
        /// Initializes a new instance of the Urls class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Urls(Amadeus client)
        {
            this.checkinLinks = new CheckinLinks(client);
        }

    }

}
