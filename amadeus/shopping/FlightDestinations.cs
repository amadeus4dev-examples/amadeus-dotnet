using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.shopping
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/shopping/flight-destinations</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.shopping.flightDestinations;
    /// </code>
    /// </summary>
    public class FlightDestinations
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the FlightDestinations class.
        /// </summary>
        /// <param name="client">Client.</param>
        public FlightDestinations(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Find the cheapest destinations where 
        /// you can fly to.
        /// </para>
        /// 
        /// <code>
        /// amadeus.shopping.flightDestinations.get(Params
        ///     .with("origin", "LHR"));
        /// </code>
        /// </summary>
        /// <returns>an API response object.</returns>
        /// <param name="_params">the parameters to send to the API.</param>
        public FlightDestination[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/shopping/flight-destinations", _params);
                return (FlightDestination[])Resource.fromArray(response, typeof(FlightDestination[]));
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
        public FlightDestination[] get()
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
