using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.shopping
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/shopping/hotel-offers/by-hotel</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping.HotelOffersByHotel;
    /// </code>
    /// </summary>
    public class HotelOffersByHotel
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the HotelOffersByHotel class.
        /// </summary>
        /// <param name="client">Client.</param>
        public HotelOffersByHotel(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Get all offers for a dedicated hotel.
        /// </para>
        /// 
        /// <code>
        /// amadeus.shopping.HotelOffersByHotel.get(Params
        ///     .with("hotelId", "XKPARC12"));
        /// </code>
        /// </summary>
        /// <returns>an API response object.</returns>
        /// <param name="_params">the parameters to send to the API.</param>
        public amadeus.resources.HotelOffer[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v2/shopping/hotel-offers/by-hotel", _params);
                return (amadeus.resources.HotelOffer[])Resource.fromArray(response, typeof(amadeus.resources.HotelOffer[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="get(Params)"/>
        /// </summary>
        /// <returns></returns>
        public amadeus.resources.HotelOffer[] get()
        {
            try
            {
                return get(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

    }

}