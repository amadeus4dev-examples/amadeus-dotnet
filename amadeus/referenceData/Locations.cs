using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;
using resources.referenceData.locations;

namespace resources.referenceData
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/reference-data/locations</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.referenceData.locations;
    /// </code>
    /// </summary>
    public class Locations
    {

        /// <summary>
        /// Any locations
        /// </summary>
        public static string ANY = "AIRPORT,CITY";

        /// <summary>
        /// Aiport locations
        /// </summary>
        public static string AIRPORT = "AIRPORT";

        /// <summary>
        /// City locations
        /// </summary>
        public static string CITY = "CITY";

        internal Amadeus client { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v2/reference-data/urls/checkin-links</code> endpoints.
        /// </summary>
        /// <value>The airports.</value>
        public Airports airports { get; set; }

        /// <summary>
        /// Initializes a new instance of the Locations class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Locations(Amadeus client)
        {
            this.client = client;
            this.airports = new Airports(client);
        }

        /// <summary>
        /// <para>
        /// Returns a list of airports and cities matching a given keyword.
        /// </para>
        /// 
        /// <code>
        /// amadeus.referenceData.locations.get(Params
        ///     .with("keyword", "lon)
        ///     .and("subType", Locations.ANY));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public amadeus.resources.Location[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/reference-data/locations", _params);
                return (amadeus.resources.Location[]) Resource.fromArray(response, typeof(amadeus.resources.Location[]));
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
