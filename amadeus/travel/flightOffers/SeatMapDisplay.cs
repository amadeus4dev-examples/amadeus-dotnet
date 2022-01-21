using amadeus.exceptions;
using amadeus.resources;
using System;
using System.Collections.Generic;

namespace amadeus.travel.flightOffers
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/seatmaps> ,
    /// endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.restrictions.travelRestrictions;
    /// </code>
    /// </summary>
    public class SeatMapDisplay
    {
        internal Amadeus client { get; set; }

        public SeatMapDisplay(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// /shopping/seatmaps.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.flightOffers.seatMap.getSeatMap(Params.with("flightOrderId", "MlpZVkFMfFdBVFNPTnwyMDE1LTExLTAy"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public SeatMap[] getSeatMap(Params _params)
        {
            try
            {
                string path = "/v1/shopping/seatmaps";
                Response response = client.get(path, _params);
                return (SeatMap[])Resource.fromArray(response, typeof(SeatMap[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="getSeatMap(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public SeatMap[] getSeatMap()
        {
            try
            {
                return getSeatMap(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// /shopping/seatmaps.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.flightOffers.seatMap.postSeatMap(body);
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">body the parameters to send to the API as a JSonObject</param>
        public SeatMap[] postSeatMap(Params _params, string body)
        {
            try
            {
                Response response = client.post("/v1/shopping/seatmaps", _params, body);
                return (SeatMap[])Resource.fromArray(response, typeof(SeatMap[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>post</code> without any parameters.
        /// <see cref="postSeatMap(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public SeatMap[] postSeatMap()
        {
            try
            {
                return postSeatMap(null, null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }
    }
}
