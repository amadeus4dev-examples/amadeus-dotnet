using System;
using amadeus;
using amadeus.exceptions;
using amadeus.resources;

namespace resources.referenceData.urls
{

    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v2/reference-data/urls/checkin-links</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object.
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder(API_KEY, API_SECRET).build();
    /// amadeus.referenceData.urls.checkinLinks;
    /// </code>
    /// </summary>
    public class CheckinLinks
    {

        internal Amadeus client { get; set; }

        /// <summary>
        /// Initializes a new instance of the CheckinLinks class.
        /// </summary>
        /// <param name="client">Client.</param>
        public CheckinLinks(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// Returns the checkin links for an airline, for the
        /// language of your choice.
        /// </para>
        /// 
        /// <code>
        /// amadeus.referenceData.urls.checkinLinks.get(Params.with("airlineCode", "BA"));
        /// </code>
        /// </summary>
        /// <returns>an API resource</returns>
        /// <param name="_params">the parameters to send to the API</param>
        public CheckinLink[] get(Params _params)
        {
            try
            {
                Response response = client.get("/v2/reference-data/urls/checkin-links", _params);
                return (CheckinLink[])Resource.fromArray(response, typeof(CheckinLink[]));
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
        public CheckinLink[] get()
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
