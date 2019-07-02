using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.travel.analytics.airTraffic
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/analytics/air-traffic/busiest-period</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.analytics.airTraffis.busiestPeriod;
    /// </code>
    /// </summary>
    public class BusiestPeriod
    {

        /// <summary>
        /// ARRIVING constant
        /// </summary>
        public static string ARRIVING = "ARRIVING";

        /// <summary>
        /// DEPARTING constant
        /// </summary>
        public static string DEPARTING = "DEPARTING";

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the BusiestPeriod class.
        /// </summary>
        /// <param name="client">Client.</param>
        public BusiestPeriod(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a list of busiest periods reports.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.analytics.airTraffic.busiestPeriod.get(Params
        ///     .with("cityCode", "PAR")
        ///     .and("period", "2017"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public Period[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/travel/analytics/air-traffic/busiest-period", _params);
                return (Period[])Resource.fromArray(response, typeof(Period[]));
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
        public Period[] get()
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

