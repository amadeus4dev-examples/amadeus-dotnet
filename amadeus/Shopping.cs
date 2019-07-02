using System;
using amadeus.shopping;

namespace amadeus
{

    /// <summary>
    /// 
    /// Shopping
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
    public class Shopping
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flight-dates</code> endpoints.
        /// </summary>
        public FlightDates flightDates;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flight-destinations</code> endpoints.
        /// </summary>
        public FlightDestinations flightDestinations;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flight-offers</code> endpoints.
        /// </summary>
        public FlightOffers flightOffers;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/shopping/hotel-offers</code> endpoints.
        /// </summary>
        ///
        public HotelOffers hotelOffers;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/shopping/hotel-offers/by-hotel</code> endpoints.
        /// </summary>
        public HotelOffersByHotel hotelOffersByHotel;

        /// <summary>
        /// Initializes a new instance of the Shopping class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Shopping(Amadeus client)
        {
            this.client = client;
            this.flightDates = new FlightDates(client);
            this.flightDestinations = new FlightDestinations(client);
            this.flightOffers = new FlightOffers(client);
            this.hotelOffers = new HotelOffers(client);
            this.hotelOffersByHotel = new HotelOffersByHotel(client);
        }
        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/hotel/:hotel_id</code> endpoints.
        /// </summary>
        /// <returns>The offer.</returns>
        /// <param name="hotelId">Hotel identifier.</param>
        public HotelOffer hotelOffer(String hotelId)
        {
            return new HotelOffer(client, hotelId);
        }
    }

}
