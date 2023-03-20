﻿using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;
using amadeus.shopping.flightOffers;

namespace amadeus.shopping
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/flight-offers</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping.flightOffers;
    /// </code>
    /// </summary>
    public class FlightOffers
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/shopping/flight-offers/pricing</code> endpoints.
        /// </summary>
        public FlightOffersPricing pricing;

        /// <summary>
        /// Initializes a new instance of the FlightOffers class.
        /// </summary>
        /// <param name="client">Client.</param>
        public FlightOffers(Amadeus client)
        {
            this.client = client;
            this.pricing = new FlightOffersPricing(client);
        }

        /// <summary>
        /// <para>
        /// Find the cheapest bookable flights.
        /// </para>
        /// 
        /// <code>
        /// amadeus.shopping.flightOffers.get(Params
        ///     .with("originLocationCode", "LHR")
        ///     .and("destinationLocationCode", "LAX")
        ///     .and("departureDate", "2017-12-24"));
        /// </code>
        /// </summary>
        /// <returns>an API response object.</returns>
        /// <param name="_params">params the parameters to send to the API.</param>
        public FlightOffer[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v2/shopping/flight-offers", _params);
                return (FlightOffer[])Resource.fromArray(response, typeof(FlightOffer[]));
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
        /// <returns>an API response object.</returns>
        public FlightOffer[] get()
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
