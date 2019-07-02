using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.travel.analytics.airTraffic
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/analytics/air-traffic/searched</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.analytics.airTraffis.Searched;
    /// </code>
    /// </summary>
    public class Searched
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the Searched class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Searched(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a list of air traffic reports based on the number of searches.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.analytics.airTraffic.searchedByDestination.get(Params
        ///     .with("originCityCode", "MAD")
        ///     .and("searchPeriod", "2017-08")
        ///     .and("marketCountryCode", "ES"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public Search[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/travel/analytics/air-traffic/searched", _params);
                return (Search[])Resource.fromArray(response, typeof(Search[]));
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
        public Search[] get()
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


