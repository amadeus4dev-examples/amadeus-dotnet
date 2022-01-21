using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.travel
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v3/travel/trip-parser</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.tripParser;
    /// </code>
    /// </summary>
    public class TripParser
    {
        internal Amadeus client { get; set; }

        /// <summary>
        /// <para>
        /// The Trip Parser API parses the content of a document to extract trip information.
        /// Documents can be of type: PDF, XML, JSON, JPG, EML etc.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.tripParser.post(body);
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">body the parameters to send to the API as a JSonObject</param>
        public TripDetail post(Params _params)
        {
            try
            {
                Response response = client.post("/v3/travel/trip-parser", _params, null);
                return (TripDetail) Resource.fromObject(response, typeof(TripDetail));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>post</code> without any parameters.
        /// <see cref="post(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public TripDetail post()
        {
            try
            {
                return post(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }
    }
}