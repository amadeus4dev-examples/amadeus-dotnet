using amadeus.exceptions;
using amadeus.resources;
using System;
using System.Collections.Generic;

namespace amadeus.safety.safetyRatedLocations
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/safety/safety-rated-locations> ,
    /// <code>/v1/safety/safety-rated-locations/by-square> ,
    /// <code>/v1/safety/safety-rated-locations/{safety-rated-locationId}>
    /// endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.safety.safePlace;
    /// </code>
    /// </summary>
    public class SafePlace
    {
        internal Amadeus client { get; set; }

        public SafePlace(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// /safety/safety-rated-locations.
        /// </para>
        /// 
        /// <code>
        /// amadeus.safety.safePlace.getByGeoCode(Params.with("latitude", "41.397158").and("longitude", "2.160873"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public SafetyRatedLocation[] getByGeoCode(Params _params)
        {
            try
            {
                string path = "/v1/safety/safety-rated-locations";
                Response response = client.get(path, _params);
                return (SafetyRatedLocation[])Resource.fromArray(response, typeof(SafetyRatedLocation[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="getByGeoCode(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public SafetyRatedLocation[] getByGeoCode()
        {
            try
            {
                return getByGeoCode(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// /safety/safety-rated-locations/by-square.
        /// </para>
        /// 
        /// <code>
        /// amadeus.safety.safePlace.getBySquare(Params.with("north", "41.397158").and("west", "2.160873").and("south", "41.394582").and("east", "2.177181"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public SafetyRatedLocation[] getBySquare(Params _params)
        {
            try
            {
                string path = "/v1/safety/safety-rated-locations/by-square";
                Response response = client.get(path, _params);
                return (SafetyRatedLocation[])Resource.fromArray(response, typeof(SafetyRatedLocation[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="getBySquare(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public SafetyRatedLocation[] getBySquare()
        {
            try
            {
                return getBySquare(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// /v1/safety/safety-rated-locations/{safety-rated-locationId}.
        /// </para>
        /// 
        /// <code>
        /// amadeus.safety.safePlace.getById(Params.with("safety-rated-locationId", "Q930402719"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public SafetyRatedLocation getById(Params _params)
        {
            try
            {
                var parameters = _params.GetEnumerator();
                parameters.MoveNext();
                var id = parameters.Current;
                string path = "/v1/safety/safety-rated-locations/" + id.Value;
                Response response = client.get(path, _params);
                return (SafetyRatedLocation)Resource.fromObject(response, typeof(SafetyRatedLocation));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="getById(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public SafetyRatedLocation getById()
        {
            try
            {
                return getById(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }
    }
}
