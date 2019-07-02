using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace resources.referenceData
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/reference-data/airlines</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.referenceData.airlines;
    /// </code>
    /// </summary>
    public class Airlines
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the Airline class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Airlines(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns the airline name and code.
        /// </para>
        /// <code>
        /// amadeus.referenceData.airlines.get(Params.with("airlineCodes", "BA"));
        /// </code>
        /// </summary>
        /// <returns>an API response object.</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public Airline[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v1/reference-data/airlines", _params);
                return (Airline[])Resource.fromArray(response, typeof(Airline[]));
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
        public Airline[] get()
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
