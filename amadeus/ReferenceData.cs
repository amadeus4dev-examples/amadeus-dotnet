using System;
using amadeus.referenceData;
using resources.referenceData;

namespace amadeus
{
    /// <summary>
    /// 
    /// ReferenceData
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/reference-data</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.referenceData;
    /// </code>
    /// 
    /// </summary>
    public class ReferenceData
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/urls</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public Urls urls { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/locations</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public Locations locations { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/shopping</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public ShoppingNew shopping { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/safety</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public Safety safety { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/dutyOfCare</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public DutyOfCare dutyOfCare { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/booking</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public Booking booking { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/travel</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public TravelNew travel { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/airlines</code> endpoints.
        /// </summary>
        /// <value>The urls.</value>
        public Airlines airlines { get; set; }

        /// <summary>
        /// Initializes a new instance of the ReferenceData class.
        /// </summary>
        /// <param name="client">Client.</param>
        public ReferenceData(Amadeus client)
        {
            this.client = client;
            this.urls = new Urls(client);
            this.locations = new Locations(client);
            this.airlines = new Airlines(client);
            this.shopping = new ShoppingNew(client);
            this.safety = new Safety(client);
            this.dutyOfCare = new DutyOfCare(client);
            this.booking = new Booking(client);
            this.travel = new TravelNew(client);

        }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/location/:hotel_id</code> endpoints.
        /// </summary>
        /// <returns>The location.</returns>
        /// <param name="locationId">Location identifier.</param>
        public Location location(string locationId)
        {
            return new Location(client, locationId);
        }

    }
}
