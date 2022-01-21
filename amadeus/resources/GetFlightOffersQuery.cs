using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An GetFlightOffersQuery object.
    /// </summary>
    public class GetFlightOffersQuery
    {
        public GetFlightOffersQuery() { }

        /// <summary>
        /// Gets or sets the type of the currencyCode.
        /// </summary>
        /// <value>The type of the currencyCode.</value>
        public string currencyCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the originDestinations.
        /// </summary>
        /// <value>The type of the originDestinations.</value>
        public List<OriginDestination> originDestinations { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelers.
        /// </summary>
        /// <value>The type of the travelers.</value>
        public List<TravelerInfo> travelers { get; set; }

        /// <summary>
        /// Gets or sets the type of the sources.
        /// </summary>
        /// <value>The type of the sources.</value>
        public List<SourcesFlight> sources { get; set; }

        /// <summary>
        /// Gets or sets the type of the searchCriteria.
        /// </summary>
        /// <value>The type of the searchCriteria.</value>
        public SearchCriteria searchCriteria { get; set; }
    }
}
