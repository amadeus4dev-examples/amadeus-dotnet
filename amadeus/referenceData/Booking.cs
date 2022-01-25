using System;
using amadeus.booking;

namespace amadeus.referenceData
{

    /// <summary>
    /// 
    /// Booking
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/booking</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.booking;
    /// </code>
    /// 
    /// </summary>
    public class Booking
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/booking/flight-orders</code> endpoints.
        /// </summary>
        public FlightOrderManagement flightOrderManagement;

        /// <summary>
        /// Initializes a new instance of the Booking class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Booking(Amadeus client)
        {
            this.client = client;
            this.flightOrderManagement = new FlightOrderManagement(client);

        }

    }

}
