using System;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.shopping
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/shopping/hotel-offers/:offer_id</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder(API_KEY, API_SECRET).build();
    /// amadeus.shopping.HotelOffer(offerId);
    /// </code>
    /// </summary>
    public class HotelOffer
    {
        internal Amadeus client;
        internal string offerId;

        /// <summary>
        /// Initializes a new instance of the HotelOffer class.
        /// </summary>
        /// <param name="client">Client.</param>
        /// <param name="offerId">Offer identifier.</param>
        public HotelOffer(Amadeus client, string offerId)
        {
            this.offerId = offerId;
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns details for a specific offer.
        /// </para>
        /// 
        /// <code>
        /// amadeus.shopping.HotelOffer("XXX").get();
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public amadeus.resources.HotelOffer get(Params _params)
        {
            try
            {
                string path = "/v2/shopping/hotel-offers/" + offerId;
                Response response = client.get(path, _params);
                return (amadeus.resources.HotelOffer)Resource.fromObject(response, typeof(amadeus.resources.HotelOffer));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters
        /// <see cref="get(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public amadeus.resources.HotelOffer get()
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
