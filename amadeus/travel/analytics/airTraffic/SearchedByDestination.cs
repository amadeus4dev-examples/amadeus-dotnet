using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.travel.analytics.airTraffic
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/travel/analytics/air-traffic/searched/by-destination</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.travel.analytics.airTraffis.SearchedByDestination;
    /// </code>
    /// </summary>
    public class SearchedByDestination
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the SearchedByDestination class.
        /// </summary>
        /// <param name="client">Client.</param>
        public SearchedByDestination(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns a list of busiest periods reports.
        /// </para>
        /// 
        /// <code>
        /// amadeus.travel.analytics.airTraffic.searchedByDestination.get(Params
        ///     .with("originCityCode", "MAD")
        ///     .and("destinationCityCode", "NYC") 
        ///     .and("searchPeriod", "2017-08")
        ///     .and("marketCountryCode", "ES"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public SearchedDestination get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/travel/analytics/air-traffic/searched/by-destination", _params);
                return (SearchedDestination)Resource.fromObject(response, typeof(SearchedDestination));
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
        public SearchedDestination get()
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

