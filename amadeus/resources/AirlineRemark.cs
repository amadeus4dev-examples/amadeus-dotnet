using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AirlineRemark object.
    /// </summary>
    public class AirlineRemark
    {
        internal AirlineRemark() { }

        /// <summary>
        /// Gets or sets the type of the subType.
        /// </summary>
        /// <value>The type of the subType.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the type of the keyword.
        /// </summary>
        /// <value>The type of the keyword.</value>
        public string keyword { get; set; }

        /// <summary>
        /// Gets or sets the type of the airlineCode.
        /// </summary>
        /// <value>The type of the airlineCode.</value>
        public string airlineCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerIds.
        /// </summary>
        /// <value>The type of the travelerIds.</value>
        public List<string> travelerIds { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOfferIds.
        /// </summary>
        /// <value>The type of the flightOfferIds.</value>
        public List<string> flightOfferIds { get; set; }
    }
}
