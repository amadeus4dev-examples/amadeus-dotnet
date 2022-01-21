using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TravelerInfo object.
    /// </summary>
    public class TravelerInfo
    {
        public TravelerInfo() { }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerType.
        /// </summary>
        /// <value>The type of the travelerType.</value>
        public string travelerType { get; set; }

        /// <summary>
        /// Gets or sets the type of the associatedAdultId.
        /// </summary>
        /// <value>The type of the associatedAdultId.</value>
        public string associatedAdultId { get; set; }
    }
}
