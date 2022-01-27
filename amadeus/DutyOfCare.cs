using System;
using amadeus.dutyOfcare;

namespace amadeus
{

    /// <summary>
    /// 
    /// DutyOfCare
    /// 
    /// <para>
    /// A namespaced client for the
    /// <code>/v1/duty-of-care</code> endpoints.
    /// </para>
    /// 
    /// <para>Access via the Amadeus client object.</para>
    /// 
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("clientId", "secret").build();
    /// amadeus.dutyOfCare;
    /// </code>
    /// 
    /// </summary>
    public class DutyOfCare
    {
        internal Amadeus client;

        /// <summary>
        /// A namespaced client for the
        /// <code>/v1/duty-of-care/diseases</code> endpoints.
        /// </summary>
        public Diseases diseases;

        /// <summary>
        /// Initializes a new instance of the DutyOfCare class.
        /// </summary>
        /// <param name="client">Client.</param>
        public DutyOfCare(Amadeus client)
        {
            this.client = client;
            this.diseases = new Diseases(client);

        }

    }

}
