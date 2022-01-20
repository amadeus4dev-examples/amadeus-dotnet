using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AirTravelDocument object.
    /// </summary>
    public class AirTravelDocument
    {
        internal AirTravelDocument() { }

        /// <summary>
        /// Gets or sets the type of the documentType.
        /// </summary>
        /// <value>The type of the documentType.</value>
        public string documentType { get; set; }

        /// <summary>
        /// Gets or sets the type of the documentNumber.
        /// </summary>
        /// <value>The type of the documentNumber.</value>
        public string documentNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the documentStatus.
        /// </summary>
        /// <value>The type of the documentStatus.</value>
        public string documentStatus { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerId.
        /// </summary>
        /// <value>The type of the travelerId.</value>
        public string travelerId { get; set; }

        /// <summary>
        /// Gets or sets the type of the segmentIds.
        /// </summary>
        /// <value>The type of the segmentIds.</value>
        public List<string> segmentIds { get; set; }
    }
}
