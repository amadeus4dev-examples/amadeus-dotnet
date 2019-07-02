using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.shopping
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/flight-dates</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping.flightDates;
    /// </code>
    /// </summary>
    public class FlightDates
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the FlightDates class.
        /// </summary>
        /// <param name="client">Client.</param>
        public FlightDates(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Find the cheapest flight dates from an 
        /// origin to a destination.
        /// </para>
        /// 
        /// <code>
        /// amadeus.shopping.flightDates.get(Params
        ///     .with("origin", "LHR")
        ///     .and("destination", "PAR"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public FlightDate[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/shopping/flight-dates", _params);
                return (FlightDate[])Resource.fromArray(response, typeof(FlightDate[]));
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
        /// <returns>The get.</returns>
        public FlightDate[] get()
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

