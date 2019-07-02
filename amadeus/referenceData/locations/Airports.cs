using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace resources.referenceData.locations
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/reference-data/locations/airports</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.referenceData.locations.airports;
    /// </code>
    /// </summary>
    public class Airports
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the Airports class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Airports(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a list of relevant airports near to a given point.
        /// </para>
        /// 
        /// <code>
        /// amadeus.referenceData.locations.airports.get(Params
        ///     .with("longitude", 49.0000)
        ///     .and("latitude", 2.55));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public amadeus.resources.Location[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/reference-data/locations/airports", _params);
                return (amadeus.resources.Location[])Resource.fromArray(response, typeof(amadeus.resources.Location[]));
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
        public amadeus.resources.Location[] get()
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
