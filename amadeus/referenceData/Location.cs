using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace resources.referenceData
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/reference-data/locations/:location_id</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder(API_KEY, API_SECRET).build();
    /// amadeus.referenceData.location(locationId);
    /// </code>
    /// </summary>
    public class Location
    {

        internal Amadeus client { get; set; }
        internal string locationId { get; set; }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        /// <param name="client">Client.</param>
        /// <param name="locationId">Location identifier.</param>
        public Location(Amadeus client, string locationId)
        {
            this.client = client;
            this.locationId = locationId;
        }

        /// <summary>
        /// <para>
        /// Returns details for a specific airport.
        /// </para>
        /// 
        /// <code>
        /// amadeus.referenceData.locations("ALHR').get();
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public amadeus.resources.Location get(Params _params)
        {
            try
            {
                string path = "/v1/reference-data/locations/" + locationId;
                Response response = client.get(path, _params);
                return (amadeus.resources.Location) Resource.fromObject(response, typeof(amadeus.resources.Location));
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
        public amadeus.resources.Location get()
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
