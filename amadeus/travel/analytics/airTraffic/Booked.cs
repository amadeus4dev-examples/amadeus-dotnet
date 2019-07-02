using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.travel.analytics.airTraffic
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/analytics/air-traffic/booked</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.analytics.airTraffis.booked;
    /// </code>
    /// </summary>
    public class Booked
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the Booked class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Booked(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a list of air traffic reports.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.analytics.airTraffic.booked.get(Params
        ///     .with("originCityCode", "LHR")
        ///     .and("period", "2017-03"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public amadeus.resources.AirTraffic[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/travel/analytics/air-traffic/booked", _params);
                return (amadeus.resources.AirTraffic[])Resource.fromArray(response, typeof(amadeus.resources.AirTraffic[]));
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
        public amadeus.resources.AirTraffic[] get()
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
