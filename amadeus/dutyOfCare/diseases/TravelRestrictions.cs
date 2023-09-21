using amadeus.exceptions;
using amadeus.resources;

namespace amadeus.dutyOfcare
{
    /// <summary>
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/duty-of-care/diseases/covid19-area-report</code> endpoints.
    /// </para>
    /// 
    /// <para>
    /// Access via the Amadeus client object
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.dutyOfCare.travelRestrictions;
    /// </code>
    /// </summary>
    public class TravelRestrictions
    {
        internal Amadeus client { get; set; }

        public TravelRestrictions(Amadeus client)
        {
            this.client = client;
        }

        /// <summary>
        /// <para>
        /// /duty-of-care/diseases/covid19-area-report.
        /// </para>
        /// 
        /// <code>
        /// amadeus.dutyOfCare.travelRestrictions.get(Params.with("countryCode ", "US"));
        /// </code>
        /// </summary>
        /// <returns>an API response object</returns>
        /// <param name="_params">params the parameters to send to the API</param>
        public DiseaseAreaReport get(Params _params)
        {
            try
            {
                string path = "/v2/duty-of-care/diseases/covid19-area-report";
                Response response = client.get(path, _params);
                return (DiseaseAreaReport)Resource.fromObject(response, typeof(DiseaseAreaReport));
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
        public DiseaseAreaReport get()
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
