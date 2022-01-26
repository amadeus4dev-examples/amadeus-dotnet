using System;
using amadeus.dutyOfcare;

namespace amadeus
{

    /// <summary>
    /// 
    /// Diseases
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/duty-of-care/diseases</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.dutyOfCare.diseases;
    /// </code>
    /// 
    /// </summary>
    public class Diseases
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/duty-of-care/diseases/covid19-area-report</code> endpoints.
        /// </summary>
        public TravelRestrictions covid19AreaReport;

        /// <summary>
        /// Initializes a new instance of the Diseases class.
        /// </summary>
        /// <param name="client">Client.</param>
        public Diseases(Amadeus client)
        {
            this.client = client;
            this.covid19AreaReport = new TravelRestrictions(client);

        }

    }

}
