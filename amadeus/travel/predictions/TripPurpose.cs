using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.travel.predictions
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/predictions/trip-purpose</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.predictions.tripPurpose;
    /// </code>
    /// </summary>
    public class TripPurpose
    {
        internal Amadeus client { get; set; }

        public TripPurpose(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a trip purpose prediction.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.predictions.tripPurpose.get(Params.with("originLocationCode", "NYC").and("destinationLocationCode", "MAD").and("departureDate", "2020-08-01").and("returnDate", "2020-08-12"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public Prediction get(Params _params)
        {
            try
            {
                string path = "/v1/travel/predictions/trip-purpose";
                Response response = client.get(path, _params);
                return (Prediction) Resource.fromObject(response, typeof(Prediction));
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
        /// <returns>an API response object</returns>
        public Prediction get()
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
