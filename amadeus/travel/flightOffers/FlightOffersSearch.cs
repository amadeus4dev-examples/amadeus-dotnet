using amadeus.exceptions;
using amadeus.resources;
using System;
using System.Collections.Generic;

namespace amadeus.travel.flightOffers
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/flight-offers> ,
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
    public class FlightOffersSearch
    {
        internal Amadeus client { get; set; }

        public FlightOffersSearch(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// /shopping/flight-offers.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.flightOffers.flightOffers.getFlightOffers(Params.with("originLocationCode", "SYD").and("destinationLocationCode", "BKK").and("departureDate", "2022-03-01").and("adults", "1"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public FlightOffer[] getFlightOffers(Params _params)
        {
            try
            {
                string path = "/v2/shopping/flight-offers";
                Response response = client.get(path, _params);
                return (FlightOffer[])Resource.fromArray(response, typeof(FlightOffer[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>get</code> without any parameters.
        /// <see cref="getFlightOffers(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public FlightOffer[] getFlightOffers()
        {
            try
            {
                return getFlightOffers(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>
        /// /shopping/flight-offers.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.flightOffers.flightOffers.postFlightOffers(body);
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">body the parameters to send to the API as a JSonObject</param>
        public FlightOffer[] postFlightOffers(Params _params)
        {
            try
            {
                Response response = client.post("/v2/shopping/flight-offers", _params, null);
                return (FlightOffer[])Resource.fromArray(response, typeof(FlightOffer[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>post</code> without any parameters.
        /// <see cref="postFlightOffers(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public FlightOffer[] postFlightOffers()
        {
            try
            {
                return postFlightOffers(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }
    }
}
