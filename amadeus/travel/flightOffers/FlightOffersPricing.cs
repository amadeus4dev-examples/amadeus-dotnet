using amadeus.exceptions;
using amadeus.resources;
using System;
using System.Collections.Generic;

namespace amadeus.travel.flightOffers
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/flight-offers/pricing> ,
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
    public class FlightOffersPricing
    {
        internal Amadeus client { get; set; }

        public FlightOffersPricing(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// /shopping/flight-offers/pricing.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.flightOffers.flightOffers.postFlightOffersPricing(body);
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">body the parameters to send to the API as a JSonObject</param>
        public FlightOfferPricingOutput[] postFlightOffersPricing(Params _params)
        {
            try
            {
                var parameters = _params.GetEnumerator();
                parameters.MoveNext();
                var body = parameters.Current;
                Response response = client.post("/v1/shopping/flight-offers/pricing", null, body.Value);

                return (FlightOfferPricingOutput[])Resource.fromArray(response, typeof(FlightOfferPricingOutput[]));
            }
            catch (ResponseException)
            {
                throw;
            }
        }

        /// <summary>
        /// Convenience method for calling <code>post</code> without any parameters.
        /// <see cref="postFlightOffersPricing(Params)"/>
        /// </summary>
        /// <returns>an API response object</returns>
        public FlightOfferPricingOutput[] postFlightOffersPricing()
        {
            try
            {
                return postFlightOffersPricing(null);
            }
            catch (ResponseException)
            {
                throw;
            }
        }
    }
}
