using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An SafetyRatedLocation object.
    /// </summary>
    public class SafetyRatedLocation : Resource
    {
        internal SafetyRatedLocation() { }

        /// <summary>
        /// Gets or sets the type of the safetyScore.
        /// </summary>
        /// <value>The type of the safetyScore.</value>
        public SafetyScore safetyScore { get; set; }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the self.
        /// </summary>
        /// <value>The type of the self.</value>
        public Link self { get; set; }

        /// <summary>
        /// Gets or sets the type of the type.
        /// </summary>
        /// <value>The type of the type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the subType.
        /// </summary>
        /// <value>The type of the subType.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the geoCode.
        /// </summary>
        /// <value>The type of the geoCode.</value>
        public GeoCode geoCode { get; set; }
    }
}
