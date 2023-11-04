using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FareDetailsBySegment object.
    /// </summary>
    public class FareDetailsBySegment
    {
        internal FareDetailsBySegment() { }

        /// <summary>
        /// Gets or sets the type of the segmentId.
        /// </summary>
        /// <value>The type of the segmentId.</value>
        public string segmentId { get; set; }

        /// <summary>
        /// Gets or sets the type of the cabin.
        /// </summary>
        /// <value>The type of the cabin.</value>
        public string cabin { get; set; }

        /// <summary>
        /// Gets or sets the type of the fareBasis.
        /// </summary>
        /// <value>The type of the fareBasis.</value>
        public string fareBasis { get; set; }

        /// <summary>
        /// Gets or sets the type of the brandedFare.
        /// </summary>
        /// <value>The type of the brandedFare.</value>
        public string brandedFare { get; set; }

        /// <summary>
        /// Gets or sets the type of the class.
        /// </summary>
        /// <value>The type of the class.</value>
        [JsonProperty("class")]
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the type of the isAllotment.
        /// </summary>
        /// <value>The type of the isAllotment.</value>
        public bool isAllotment { get; set; }

        /// <summary>
        /// Gets or sets the type of the allotmentDetails.
        /// </summary>
        /// <value>The type of the allotmentDetails.</value>
        public AllotmentDetails allotmentDetails { get; set; }

        /// <summary>
        /// Gets or sets the type of the sliceDiceIndicator.
        /// </summary>
        /// <value>The type of the sliceDiceIndicator.</value>
        public string sliceDiceIndicator { get; set; }

        /// <summary>
        /// Gets or sets the type of the includedCheckedBags.
        /// </summary>
        /// <value>The type of the includedCheckedBags.</value>
        public BaggageAllowance includedCheckedBags { get; set; }

        /// <summary>
        /// Gets or sets the type of the additionalServices.
        /// </summary>
        /// <value>The type of the additionalServices.</value>
        public AdditionalServicesRequest additionalServices { get; set; }
    }
}
