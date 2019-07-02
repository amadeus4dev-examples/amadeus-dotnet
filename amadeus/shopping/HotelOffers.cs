using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace amadeus.shopping
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/hotel-offers</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping.hotelOffers;
    /// </code>
    /// </summary>
    public class HotelOffers
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the HotelOffers class.
        /// </summary>
        /// <param name="client">Client.</param>
        public HotelOffers(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Search for hotels and retrieve availability and rates information.
        /// </para>
        /// <code>
        /// amadeus.shopping.hotelOffers.get(Params
        ///     .with("cityCode", "PAR"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public amadeus.resources.HotelOffer[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v2/shopping/hotel-offers", _params);
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
        /// <returns>The get.</returns>
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