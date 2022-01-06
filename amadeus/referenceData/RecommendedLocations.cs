using amadeus.exceptions;
using amadeus.resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.referenceData
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/reference-data/recommended-locations</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder(API_KEY, API_SECRET).build();
    /// amadeus.referenceData.recommendedLocations;
    /// </code>
    /// </summary>
    public class RecommendedLocations
    {
        internal Amadeus client { get; set; }

        public RecommendedLocations(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a list of destination recommendations.
        /// </para>
        /// 
        /// <code>
        /// amadeus.referenceData.recommendedLocations.get(Params.with("cityCodes", "PAR").and("travelerCountryCode", "FR"))
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public Location[] get(Params _params)
        {
            try
            {
                string path = "/v1/reference-data/recommended-locations";
                Response response = client.get(path, _params);
                return Resource.fromArray(response, typeof(Location[])) as Location[];
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
        public Location[] get()
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
